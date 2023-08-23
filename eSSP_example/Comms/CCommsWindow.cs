using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ITLlib;

namespace eSSP_example
{
    public partial class CCommsWindow : Form
    {
        // Variables
        int m_PacketCounter;
        bool m_bLogging;
        string m_LogText;
        StringBuilder LogText;
        StreamWriter m_SW;
        string m_FileName;
        const int SSP_POLL_CODE = 7;
        delegate void WriteToLog(string text);
        CSspLookup SspLookup = new CSspLookup();

      

        // Constructor
        public CCommsWindow()
        {
            InitializeComponent();
            m_PacketCounter = 1;
            m_bLogging = false;
            this.Text = "NV11 Comms";
            // create persistent log
            try
            {
                // if the log dir doesn't exist, create it
                string logDir = "Logs\\" + DateTime.Now.ToLongDateString();
                if (!Directory.Exists(logDir))
                    Directory.CreateDirectory(logDir);
                // name this log as current time
                m_FileName = DateTime.Now.Hour.ToString() + "h" + DateTime.Now.Minute.ToString() + "m" + DateTime.Now.Second.ToString() + "s.txt";
                // create/open the file
                m_SW = File.AppendText(logDir + "\\" + m_FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "EXCEPTION");
                base.Dispose();
            }
        }

        // On loading, start logging and turn off the cross
        private void CommsWindow_Load(object sender, EventArgs e)
        {
            m_bLogging = true;
            this.ControlBox = false;
            
            m_SW.Write("\r\nStarted logging - " + DateTime.Now);
        }

        // On closing, stop logging
        private void CommsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_bLogging = false;
            m_SW.Close();
        }

        // This function should be called in a loop, it monitors the SSP_COMMAND_INFO parameter
        // and writes the info to a text box in a readable format. If the failedCommand bool
        // is set true then it will not write a response.
        public void UpdateLog(SSP_COMMAND_INFO info, bool failedCommand = false)
        {
            if (m_bLogging)
            {
                string byteStr;
                byte len;
                byte[] pollResponse;

                // NON-ENCRPYTED
                // transmission
                LogText = new StringBuilder(500);
                LogText.AppendLine();
                LogText.AppendLine("No Encryption");
                LogText.Append("Sent Packet #");
                LogText.AppendLine(m_PacketCounter.ToString());
                len = info.PreEncryptedTransmit.PacketData[2];
                LogText.Append("Length: ");
                LogText.AppendLine(len.ToString());
                LogText.Append("Sync: ");
                LogText.AppendLine((info.PreEncryptedTransmit.PacketData[1] >> 7).ToString());
                LogText.Append("Command: ");
                LogText.AppendLine(SspLookup.GetCommandName(info.PreEncryptedTransmit.PacketData[3]));
                LogText.Append("Data: ");
                byteStr = BitConverter.ToString(info.PreEncryptedTransmit.PacketData, 3, len);
                LogText.AppendLine(FormatByteString(byteStr));
                // received

                if (!failedCommand)
                {
                    LogText.AppendLine();
                    LogText.Append("Received Packet #");
                    LogText.AppendLine(m_PacketCounter.ToString());
                    len = info.PreEncryptedRecieve.PacketData[2];
                    LogText.Append("Length: ");
                    LogText.AppendLine(len.ToString());
                    LogText.Append("Sync: ");
                    LogText.AppendLine((info.PreEncryptedRecieve.PacketData[1] >> 7).ToString());
                    LogText.Append("Response: ");
                    LogText.AppendLine(SspLookup.GetGenericResponseName(info.PreEncryptedRecieve.PacketData[3]));
                    if (info.PreEncryptedTransmit.PacketData[3] == SSP_POLL_CODE && len > 1)
                    {
                        pollResponse = new byte[len];
                        Array.Copy(info.PreEncryptedRecieve.PacketData, 3, pollResponse, 0, len);
                        LogText.Append("Poll Response: ");
                        LogText.Append(SspLookup.GetPollResponse(pollResponse));
                    }
                    byteStr = BitConverter.ToString(info.PreEncryptedRecieve.PacketData, 3, len);
                    LogText.Append("Data: ");
                    LogText.AppendLine(FormatByteString(byteStr));
                }
                else
                {
                    LogText.AppendLine("No response...");
                }

                if (checkBox1.Checked == true)
                {
                    // ENCRYPTED
                    // transmission
                    LogText.AppendLine();
                    LogText.AppendLine("Encryption");
                    LogText.Append("Sent Packet #");
                    LogText.AppendLine(m_PacketCounter.ToString());
                    len = info.Transmit.PacketData[2];
                    LogText.Append("Length: ");
                    LogText.AppendLine(len.ToString());
                    LogText.Append("Sync: ");
                    LogText.AppendLine((info.Transmit.PacketData[1] >> 7).ToString());
                    byteStr = BitConverter.ToString(info.Transmit.PacketData, 3, len);
                    LogText.Append("Data: ");
                    LogText.AppendLine(FormatByteString(byteStr));

                    // received
                    if (!failedCommand)
                    {
                        LogText.AppendLine();
                        LogText.Append("Received Packet #");
                        LogText.AppendLine(m_PacketCounter.ToString());
                        len = info.Receive.PacketData[2];
                        LogText.Append("Length: ");
                        LogText.AppendLine(len.ToString());
                        LogText.Append("Sync: ");
                        LogText.AppendLine((info.Receive.PacketData[1] >> 7).ToString());
                        byteStr = BitConverter.ToString(info.Receive.PacketData, 3, len);
                        LogText.Append("Data: ");
                        LogText.AppendLine(FormatByteString(byteStr));
                    }
                    else
                    {
                        LogText.AppendLine("No response...");
                    }
                }

                m_LogText = LogText.ToString();

                if (logWindowText.InvokeRequired)
                {
                    WriteToLog l = new WriteToLog(AppendToWindow);
                    logWindowText.BeginInvoke(l, new object[] { m_LogText });
                }
                else
                {
                    logWindowText.AppendText(m_LogText);
                    logWindowText.SelectionStart = logWindowText.TextLength;
                }

                AppendToLog(m_LogText);
                m_PacketCounter++;
            }
        }

        private string FormatByteString(string s)
        {
            string formatted = s;
            string[] sArr;
            sArr = formatted.Split('-');
            formatted = "";
            for (int i = 0; i < sArr.Length; i++)
            {
                formatted += sArr[i];
                formatted += " ";
            }
            return formatted;
        }

        public void PauseLogging() { m_bLogging = false; }
        public void ResumeLogging() { m_bLogging = true; }

        private void AppendToWindow(string stringToAppend)
        {
            logWindowText.AppendText(stringToAppend);
            logWindowText.SelectionStart = logWindowText.TextLength;
        }

        private void AppendToLog(string stringToAppend)
        {
            m_SW.Write(stringToAppend);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace eSSP_example
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if ((ports == null) || (ports.Length == 0))
            {
                MessageBox.Show("No Serial Port found!", "ERROR");
                base.Dispose();
            }
            else
            {
                // first add current com port
                cbComPort.Items.Add(Global.ComPort);

                // add others if they are different
                Array.Sort<string>(ports);
                for (int i = 0; i < ports.Length; i++)
                {
                    if (ports[i] != Global.ComPort)
                        cbComPort.Items.Add(ports[i]);
                }
                this.cbComPort.SelectedItem = cbComPort.Items[0];
                tbSSPAddress.Text = Global.SSPAddress.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Global.ComPort = cbComPort.Text;
            try
            {
                if (tbSSPAddress.Text != "")
                    Global.SSPAddress = Byte.Parse(tbSSPAddress.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "EXCEPTION");
            }
            base.Dispose();
        }
    }
}

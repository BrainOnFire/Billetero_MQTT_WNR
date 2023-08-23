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
    public partial class frmOpenMenu : Form
    {
        string[] m_ComPorts;
        Form1 m_Parent;

        public frmOpenMenu(Form1 frm)
        {
            InitializeComponent();
            m_Parent = frm;
            if (SearchForComPorts() > 0)
                cbComPort.Items.AddRange(m_ComPorts);
            cbComPort.Text = Properties.Settings.Default.ComPort;
            ControlBox = false;
        }

        public int SearchForComPorts()
        {
            m_ComPorts = SerialPort.GetPortNames();
            return m_ComPorts.Length;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSSPAddress.Text != "")
                {
                    Global.ComPort = cbComPort.SelectedItem.ToString();
                    Global.SSPAddress = Byte.Parse(tbSSPAddress.Text);
                    m_Parent.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "EXCEPTION");
            }
        }

        private void tbSSPAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSearch_Click(sender, e);
        }
    }
}

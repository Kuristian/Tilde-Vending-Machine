using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPOSTerminalDemoApp
{
    public partial class User_Interface_COM : Form
    {
        public User_Interface_COM()
        {
            InitializeComponent();
        }

        private void User_Interface_COM_Load(object sender, EventArgs e)
        {
            //string[] ports = serialPort1.GetPortNames();
           // cboPort.Items.AddRange(ports);
            cboPort.SelectedIndex = 0;
            btnClose.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = false ;
            btnClose.Enabled = true ;
            try
            {
                serialPort1.PortName = cboPort.Text;
                serialPort1.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReceive_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if(serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(txtMessage.Text + Environment.NewLine);
                    txtMessage.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    txtReceive.Text = serialPort1.ReadExisting();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void User_Interface_COM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }
    }
}

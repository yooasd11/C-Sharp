using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class frmMain : Form
    {
        
        String _IPv4;
        int _mode, _port;

        public frmMain()
        {
            InitializeComponent();
            _IPv4 = "";
            _mode = -1;
            _port = -1;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _mode = 0;
            txtbxIP1.ReadOnly = true;
            txtbxIP2.ReadOnly = true;
            txtbxIP3.ReadOnly = true;
            txtbxIP4.ReadOnly = true;
            bttnStart.Text = "Start";
            
        }

        private void radioClient_CheckedChanged(object sender, EventArgs e)
        {
            _mode = 1;
            txtbxIP1.ReadOnly = false;
            txtbxIP2.ReadOnly = false;
            txtbxIP3.ReadOnly = false;
            txtbxIP4.ReadOnly = false;
            txtbxPort.ReadOnly = false;
            bttnStart.Text = "Connect";
        }

        private void txtbxIP1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtbxIP2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtbxIP3_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtbxIP4_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtbxPort_TextChanged(object sender, EventArgs e)
        {
        }

        private void bttnStart_Click(object sender, EventArgs e)
        {
            if (_mode == 0)
            {
                _port = int.Parse(txtbxPort.Text);
                Form _frmServer = new frmServer(_port);
                this.Hide();
                _frmServer.Show();
            }
            else if (_mode == 1)
            {
                _IPv4 = txtbxIP1.Text + "." +
                    txtbxIP2.Text + "." +
                    txtbxIP3.Text + "." +
                    txtbxIP4.Text;
                _port = int.Parse(txtbxPort.Text);
                Console.WriteLine(_IPv4);
                Form _frmClient = new frmClient(_IPv4, _port);
                this.Hide();
                _frmClient.Show();
            }
     
        }
    }
}

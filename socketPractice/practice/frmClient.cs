using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class frmClient : Form
    {
        String _IPv4;
        int _port;
        TcpClient _server = null;
        Thread _listenerThread;

        public frmClient()
        {
            InitializeComponent();
        }

        public frmClient(String _ipv4, int port)
        {
            InitializeComponent();
            _IPv4 = _ipv4;
            _port = port;
            _server = new TcpClient(_IPv4,_port);
            _listenerThread = new Thread(readMsgFromServer);
            _listenerThread.Start();
        }

        private void readMsgFromServer()
        {
            var reader = new StreamReader(_server.GetStream());
            while (true)
            {
                var msg = reader.ReadLine();
                if (msg == "clear")
                {
                    rchtxtbxLog.Clear();
                    continue;
                }
                rchtxtbxLog.AppendText(msg + "\n");
            }
        }

        private void sendMsgToServer(string msg)
        {
            var writer = new StreamWriter(_server.GetStream());
            writer.WriteLine(msg);
            writer.Flush();
        }


        private void frmClient_Load(object sender, EventArgs e)
        {

        }

        private void txtbxMsg_TextChanged(object sender, EventArgs e)
        {

        }

        //when 'Enter' pressed
        private void txtbxMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void bttnSend_Click(object sender, EventArgs e)
        {
            string msg = txtbxMsg.Text;
            sendMsgToServer(msg);
            txtbxMsg.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class frmServer : Form
    {
        int _port;
        TcpClient _server = null;
        List<TcpClient> _client = new List<TcpClient>();
        Thread _listenerTread;

        private void ClientWaiter()
        {
            if (_port < 0) return;
            var listener = new TcpListener(_port);
            listener.Start();
            while (true)
            {
                TcpClient tmpClient = listener.AcceptTcpClient();
                String connectedMsg = "Client " +
                    ((IPEndPoint)tmpClient.Client.RemoteEndPoint).Address.ToString() +
                    " connected\n";
                richbxLog.AppendText(connectedMsg);
                _client.Add(tmpClient);
            }
        }

        private void MsgCaster()
        {
            foreach (var client in _client)
            {
                
            }
        }

        public frmServer()
        {
            InitializeComponent();
            txtbxPort.Text = "Null";
            _port = -1;
        }

        public frmServer(int port)
        {
            InitializeComponent();
            _port = port;
            txtbxPort.Text = _port.ToString();
            _listenerTread = new Thread(ClientWaiter);
            _listenerTread.Start();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

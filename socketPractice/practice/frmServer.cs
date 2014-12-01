using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        List<TcpClient> _clients = new List<TcpClient>();
        Thread _waiterThread;
        Thread _listenerThread;
        TcpListener listener;

        private void clientWaiter()
        {
            if (_port < 0) return;
            listener = new TcpListener(_port);
            listener.Start();
            while (true)
            {
                TcpClient tmpClient = listener.AcceptTcpClient();
                String connectedMsg = "Client " +
                    ((IPEndPoint)tmpClient.Client.RemoteEndPoint).Address.ToString() +
                    " connected\n";
                richbxLog.AppendText(connectedMsg);
                _clients.Add(tmpClient);
            }
        }

        private void sendMsgToClient(TcpClient client, string msg)
        {
            var writer = new StreamWriter(client.GetStream());
            writer.WriteLine(msg);
            writer.Flush();
        }

        private string receiveMsgFromClient(TcpClient client)
        {
            var reader = new StreamReader(client.GetStream());
            return reader.ReadLine();
        }

        private void msgController()
        {
            List<string> listMsg = new List<string>();
            foreach (TcpClient client in _clients)
            {
                string msg = receiveMsgFromClient(client);
                richbxLog.AppendText(msg + '\n');
                listMsg.Add(msg);
            }

            foreach (string msg in listMsg)
            {
                foreach (TcpClient client in _clients)
                {
                    sendMsgToClient(client, msg);
                }
            }

            listMsg.Clear();
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
            _waiterThread = new Thread(clientWaiter);
            _waiterThread.Start();
            _listenerThread = new Thread(msgController);
            _listenerThread.Start();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

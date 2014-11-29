using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class frmClient : Form
    {
        String _IPv4;
        int _port;
        TcpClient _server = null;

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
        }

        private void frmClient_Load(object sender, EventArgs e)
        {

        }
    }
}

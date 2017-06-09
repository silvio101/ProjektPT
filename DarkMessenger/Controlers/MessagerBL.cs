using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PT_Messenger.Controlers
{
    class MessagerBL
    {
        private string username;
        private string passwd;
        public bool isConnect {get;set;}

        private Thread tcp_thread;
        private TcpClient tcp_client;
        private NetworkStream net_stream;
        private SslStream ssl_stream;
        private BinaryReader binRead;
        private BinaryWriter binWrite;
        private frmMainUI mainFrame;

        public MessagerBL(frmMainUI mainFrame, string username, string passwd)
        {
            this.username = username;
            this.passwd = passwd;
            this.mainFrame = mainFrame;
            this.isConnect = false;
            connect();
        }


        public void connect()
        {
            if(!isConnect)
            {
                tcp_thread = new Thread(new ThreadStart(ConnectInit));
                tcp_thread.Start();
                this.isConnect = true;
            }
        }
        public void ConnectInit()
        {
            try
            {
                tcp_client = new TcpClient(Properties.Settings.Default.server, 8510);
                net_stream = tcp_client.GetStream();
                ssl_stream = new SslStream(net_stream, false, new RemoteCertificateValidationCallback(CheckCert));
                ssl_stream.AuthenticateAsClient("PT_MessengerServer");

                binRead = new BinaryReader(ssl_stream, Encoding.UTF8);
                binWrite = new BinaryWriter(ssl_stream, Encoding.UTF8);
            }
            catch
            {
                
            }
            

            string hello = binRead.ReadString();
            
            this.mainFrame.changeConnState();
        }
        public static bool CheckCert(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            //return (sslPolicyErrors == SslPolicyErrors.None ? true : false);
            return true;
        }
    }
}

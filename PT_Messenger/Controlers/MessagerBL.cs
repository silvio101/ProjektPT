using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PT_Messenger.Controlers
{
    public class MessagerBL
    {
        private string login;
        private string passwd;
        private string username;
        private string surname;
        private string email;
        public bool isConnect {get;set;}
        public bool isLogged { get;set;}
        public bool isRegistry { get; set; }

        private Thread tcp_thread;
        private TcpClient tcp_client;
        private NetworkStream net_stream;
        private SslStream ssl_stream;
        private BinaryReader binRead;
        private BinaryWriter binWrite;

        public event EventHandler LoginNOK;
        public event EventHandler LoginOK;
        public event EventHandler Disconnect;
        public event EventHandler Connected;
        public event EventHandler RegOK;
        public event EventHandler Login_exist;

        public MessagerBL()
        {
            this.isConnect=false;
            this.isLogged=false;
            this.isRegistry=false;
        }


        public void connect()
        {
            if(!isConnect)
            {
                tcp_thread = new Thread(new ThreadStart(ConnectInit));
                tcp_thread.Start();
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
                string hello = binRead.ReadString();
                if (hello == "HELLO") 
                {   
                    binWrite.Write("HELLO");
                    this.isConnect = true;
                    OnConnected();
                }
            }
            catch
            {
                
            }
        }
        public void Registry(string login, string pass, string name, string surname, string email)
        {
            string ans;
            this.login = login;
            this.passwd = pass;
            this.username = name;
            this.surname = surname;
            this.email = email;
            try
            {
                if (!isRegistry)
                {
                    binWrite.Write("REG");
                    binWrite.Write(this.login);
                    binWrite.Write(hashPasswd(this.passwd));
                    binWrite.Write(this.username);
                    binWrite.Write(this.surname);
                    binWrite.Write(this.email);
                    binWrite.Flush();
                    ans=binRead.ReadString();
                    if (ans == "REG_SUCCESS")
                    {
                        OnRegOK();
                        this.isRegistry=true;
                    }
                    if(ans == "LOGIN_EXIST")
                    {
                        OnLoginExist();
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void Login(string login, string pass)
        {
            this.passwd = pass;
            this.login = login;
            try
            {
                if (!isLogged)
                {
                    binWrite.Write("LOG");
                    binWrite.Write(this.login);
                    binWrite.Write(hashPasswd(this.passwd));
                    binWrite.Flush();

                    if(binRead.ReadString()=="LOGIN_SUCCESS")
                    {
                        OnLoginOK();
                        this.isLogged=true;
                    }
                    else
                    {
                        OnLoginNOK();
                    }  
                }
            }
            catch
            {
                Console.WriteLine("Popsulo sie logowanie");
            }
        }

        public static bool CheckCert(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            //return (sslPolicyErrors == SslPolicyErrors.None ? true : false);
            return true;
        }
        /*
        public bool isStillConnect()
        {
        
            try
            {
                this.binWrite.Write("CON_CHECK");
                return true;
            }
            catch
            {
                this.OnDisconnect();
                this.ssl_stream.Close();
                return false;
            }
         
        } */
        private string hashPasswd(string passwd)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(passwd);
            using(SHA512 shaM = new SHA512Managed()) 
            {
                var hashedInputBytes = shaM.ComputeHash(bytes);
                
                var hashedInputString =  new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputString.Append(b.ToString("X2"));
                return hashedInputString.ToString();
            }       
        }

        virtual protected void OnConnected()
        {
            if(Connected!=null)
                Connected(this, EventArgs.Empty);   
        }
        virtual protected void OnDisconnect()
        {
            if(Disconnect!=null)
                Disconnect(this,EventArgs.Empty);
        }
        virtual protected void OnLoginOK()
        {
            if(LoginOK!=null)
                LoginOK(this,EventArgs.Empty);
        }
        virtual protected void OnLoginNOK()
        {
            if(LoginNOK!=null)
                LoginNOK(this,EventArgs.Empty);
        }
        virtual protected void OnRegOK()
        {
            if(RegOK!=null)
                RegOK(this,EventArgs.Empty);
        }
        virtual protected void OnLoginExist()
        {
            if(Login_exist!=null)
                Login_exist(this,EventArgs.Empty);
        }
    }
}

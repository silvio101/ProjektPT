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
        public string login {get;set;}
        public string passwd { get; set; }
        public string username { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
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
        public event EventHandler LoginDENY;
        public event EventHandler Disconnect;
        public event EventHandler Connected;
        public event EventHandler RegOK;
        public event EventHandler Login_exist;
        public event EventHandler ServerError;

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
        public void disconnect()
        {
            if(isConnect)
            {
                this.ssl_stream.Close();
                this.tcp_client.Close();
                this.tcp_thread.Abort();
                this.isConnect=false;
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
                    var ans = binRead.ReadString();
                    switch (ans)
                    {
                        case "LOGIN_SUCCESS":
                        {
                            OnLoginOK();
                            this.isLogged=true;
                        }
                            break;
                        case "LOGIN_DENY":
                            OnLoginDeny();
                            break;
                        case "LOGIN_UNSUCCESS":
                            OnLoginNOK();
                            break;
                        case "500_ERROR":
                            OnServerError();
                            break;
                        default:
                            break;
                        
                    }
                }
            }
            catch
            {
                Console.WriteLine("Popsulo sie logowanie");
            }
        }
        public List<string> getUserInfo()
        {
            List<string> valsy = new List<string>();
            binWrite.Write("GET_INFO");
            valsy.Add(binRead.ReadString()); //login
            valsy.Add(binRead.ReadString()); //imie
            this.username = valsy.Last();
            valsy.Add(binRead.ReadString()); //nazwisko
            this.surname = valsy.Last();
            valsy.Add(binRead.ReadString()); //email;
            this.email = valsy.Last();
            return valsy;
        }
        public bool setUserInfo(List<string> list)
        {
            binWrite.Write("SET_INFO");
            binWrite.Write(list[0]); //imie
            binWrite.Write(list[1]); //nazwisko
            binWrite.Write(list[2]); //email
            binWrite.Flush();
            return binRead.ReadString()=="CHANGE_SUCCESS" ? true:false;
        }
        public List<string> checkUserDiff(List<string> B)
        {
            List<string> A = new List<string>();
            A.Add(this.username);
            A.Add(this.surname);
            A.Add(this.email);
            var C = A.Except(B).ToList();
            return C;
        }
        public bool passChange(string newPasswd)
        {
            binWrite.Write("PASS_CHANGE");
            binWrite.Write(hashPasswd(newPasswd));
            binWrite.Flush();
            return binRead.ReadString()=="CHANGE_PASS_SUCCESS" ? true: false;
        }
        public List<Person> searchPerson(Person who)
        {
            List<Person>result=new List<Person>();
            binWrite.Write("SEARCH_PERSON");
            binWrite.Write(who.login);
            binWrite.Write(who.username);
            binWrite.Write(who.surname);
            binWrite.Write(who.email);

            int persoCount=binRead.ReadInt32();
            for(int i=0; i<persoCount; i++)
            {
                var p = new Person();
                p.login=binRead.ReadString();
                p.username=binRead.ReadString();
                p.surname=binRead.ReadString();
                p.email=binRead.ReadString();
                result.Add(p);
            }

            return result;
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
        virtual protected void OnLoginDeny()
        {
            if(LoginDENY!=null)
                LoginDENY(this,EventArgs.Empty);
        }
        virtual protected void OnServerError()
        {
            if(ServerError != null)
                ServerError(this,EventArgs.Empty);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTClient
{
    internal class FTClient
    {
        static IPEndPoint ipEnd_client;
        static Socket socket_client; 
        public static string IPaddress = "127.0.0.1";
        public static int HostPort = 1000;
        //public static string saveFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +@"\";
        public static Label LabelMessage;

        public static void SendFile(string fileName)
        {
            try 
            {
                ipEnd_client = new IPEndPoint(IPAddress.Parse(IPaddress), HostPort);
                socket_client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                
                string folder = "";

                folder = fileName.Substring(0, fileName.LastIndexOf(@"\") + 1);
                folder = folder.Substring(fileName.LastIndexOf(@"\") + 1);

                byte[] nameFile= Encoding.UTF8.GetBytes(folder);

                if (nameFile.Length > 50000*1024 )
                {
                    LabelMessage.Invoke(new Action(() => {

                        LabelMessage.ForeColor = Color.Red;
                        LabelMessage.Text = "Cant be more than 50mb... sorry";

                    }));
                    return;
                }
                string fullPath = folder + fileName;
                byte[] dataFile= File.ReadAllBytes(fullPath);
                byte[] clientData = new byte[4+fileName.Length + dataFile.Length];
                byte[] nameFileLen = BitConverter.GetBytes(nameFile.Length);

                nameFileLen.CopyTo(clientData, 0);
                nameFile.CopyTo(clientData, 0);
                dataFile.CopyTo(clientData, 4 + nameFile.Length);
                socket_client.Connect(ipEnd_client);
                socket_client.Send(clientData, 0, clientData.Length, 0);
                socket_client.Close();
            }
            catch (Exception ex)
            {
                LabelMessage.Invoke(new Action(() => {

                    LabelMessage.ForeColor = Color.Red;
                    LabelMessage.Text = "Error server not responding"+ex.Message;

                }));
            }
        }
    }
}

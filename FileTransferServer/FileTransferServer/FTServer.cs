using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTransferServer
{
    internal class FTServer
    {
        static IPEndPoint endServer;
        static Socket socketServer;
        public static string Ip = "127.0.0.1";
        public static int HostPort = 1000;
        public static string SaveFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
        public static ListBox ListMessages;

        public static void ServerInit()
        {
            try
            {
                endServer = new IPEndPoint(IPAddress.Parse(Ip), HostPort);
                socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socketServer.Bind(endServer);

                socketServer.Connect(Ip, HostPort);


            }
            catch (Exception ex)
            {
                ListMessages.Invoke(new Action(() =>
                {
                    ListMessages.Items.Add("Server error initialized\n" + ex.Message);
                    ListMessages.SetSelected(ListMessages.Items.Count - 1, true);
                }));
                return;
            }
            try
            {
                socketServer.Listen(100);
                ListMessages.Invoke(new Action(() =>
                {
                    ListMessages.Items.Add("Server initialized and waiting file transfer");
                    ListMessages.SetSelected(ListMessages.Items.Count - 1, true);
                }));
                Socket clientSocket = socketServer.Accept();
                clientSocket.ReceiveBufferSize = 16384;

                byte[] bytes = new byte[1024 * 50000]; // 50mb
                int sizeRecived = clientSocket.Receive(bytes, bytes.Length, 0);
                int sizeFile = BitConverter.ToInt32(bytes,0);
                string fileName = Encoding.UTF8.GetString(bytes, 4, sizeFile);

                BinaryWriter bWrite = new BinaryWriter(File.Open(SaveFolder + fileName, FileMode.Append));
                bWrite.Write(bytes, 4 + fileName.Length, sizeRecived - 4 - sizeFile);

                while(sizeRecived > 0)
                {
                    sizeRecived = clientSocket.Receive(bytes, bytes.Length, 0);
                    
                    if (sizeRecived == 0)
                    {
                        bWrite.Close();
                    }
                    else
                    {
                        bWrite.Write(bytes, 0, sizeRecived);
                    }
                     ListMessages.Invoke(new Action(() =>
                {
                    ListMessages.Items.Add("File recived and save " + fileName);
                    ListMessages.SetSelected(ListMessages.Items.Count - 1, true);
                }));

                    bWrite.Close();
                    clientSocket.Close();
                }
            }
            catch (SocketException ex)
            {
                ListMessages.Invoke(new Action(() =>
                {
                    ListMessages.Items.Add("Error file reception " + ex.Message);
                    ListMessages.SetSelected(ListMessages.Items.Count - 1, true);
                }));
            }
            finally
            {
                socketServer.Close();
                socketServer.Dispose();
                ServerInit();
            }
        }
    }
}

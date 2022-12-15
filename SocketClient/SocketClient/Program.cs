using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SocketClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // InterNetwork is IPv4 | Stream is out -in data

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            try
            {
                socket.Connect(endPoint);
                Console.WriteLine("Connection Success");
                Console.Write("Write info: ");

                string info = Console.ReadLine();

                byte[] sendInfo = Encoding.Default.GetBytes(info);

                socket.Send(sendInfo);
            }
            catch (Exception)
            {
                Console.WriteLine("Error Connection");
            }

            socket.Close();

            Console.WriteLine("Press a key to exit...");

            Console.ReadKey();
        }
    }
}

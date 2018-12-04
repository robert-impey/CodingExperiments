using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Console;

namespace SocketEvents
{
    internal class Program
    {
        private const string Eol = "\r\n";

        private static void Main(string[] args)
        {
            foreach (var domain in args)
            {
                var request = $"HEAD / HTTP/1.1{Eol}" +
                              $"Host: {domain}{Eol}" +
                              $"Connection: Close{Eol}{Eol}";

                var bytesSent = Encoding.ASCII.GetBytes(request);
                var bytesReceived = new byte[256];

                IPHostEntry hostEntry = Dns.GetHostEntry(domain);
                const int port = 80;

                Socket socket = null;

                foreach (IPAddress address in hostEntry.AddressList)
                {
                    var ipe = new IPEndPoint(address, port);
                    var tempSocket = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                    tempSocket.Connect(ipe);

                    if (tempSocket.Connected)
                    {
                        socket = tempSocket;
                        break;
                    }
                }

                if (socket == null)
                {
                    WriteLine("Connection failed");
                    continue;
                }

                socket.Send(bytesSent, bytesSent.Length, 0);

                var bytes = 0;

                do
                {
                    bytes = socket.Receive(bytesReceived, bytesReceived.Length, 0);
                    WriteLine(Encoding.ASCII.GetString(bytesReceived, 0, bytes));
                } while (bytes > 0);

                socket.Dispose();
            }
        }
    }
}
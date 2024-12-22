using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            const int port = 8080;
            TcpListener server = new TcpListener(IPAddress.Any, port);
            server.Start();
            Console.WriteLine($"Сервер запущено на порті {port}. Очікування клієнтів...");

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Клієнт підключився.");

                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[256];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);

                string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                string clientIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                Console.WriteLine($"О {DateTime.Now:HH:mm} від {clientIP} отримано рядок: {receivedMessage}");

                string response = "Привіт, клієнте!";
                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                stream.Write(responseBytes, 0, responseBytes.Length);

                client.Close();
            }
        }
    }
}

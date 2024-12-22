using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            const int port = 5050;
            TcpListener server = new TcpListener(IPAddress.Any, port);
            server.Start();
            Console.WriteLine("Сервер запущено на порту {0}. Очікування запитів...", port);

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Клієнт підключився.");

                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[256];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);

                string request = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"Отримано запит від клієнта: {request}");

                string response;
                if (request.ToLower() == "time")
                {
                    response = DateTime.Now.ToString("HH:mm:ss");
                }
                else if (request.ToLower() == "date")
                {
                    response = DateTime.Now.ToString("yyyy-MM-dd");
                }
                else
                {
                    response = "Невідомий запит";
                }

                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                stream.Write(responseBytes, 0, responseBytes.Length);

                client.Close();
                Console.WriteLine("З'єднання з клієнтом закрито.");
            }
        }
    }
}

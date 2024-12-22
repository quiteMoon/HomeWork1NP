using System.Net.Sockets;
using System.Text;

namespace Client2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            string request = cmbRequest.SelectedItem.ToString();
            const string serverIP = "127.0.0.1";
            const int port = 5050;

            try
            {
                using (TcpClient client = new TcpClient(serverIP, port))
                {
                    client.ReceiveTimeout = 5000; 
                    client.SendTimeout = 5000; 

                    NetworkStream stream = client.GetStream();

                    byte[] requestBytes = Encoding.UTF8.GetBytes(request);
                    stream.Write(requestBytes, 0, requestBytes.Length);

                    byte[] buffer = new byte[256];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    txtResponse.Text = $"Отримано від сервера: {response}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

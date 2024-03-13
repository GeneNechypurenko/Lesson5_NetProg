using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5
{
    public partial class MainForm : Form
    {
        private UdpClient udpClient;
        private IPAddress multicastIp;
        private int port;
        private Task receiveTask;

        public MainForm()
        {
            InitializeComponent();

            multicastIp = IPAddress.Parse("235.0.0.0");
            port = 12345;

            udpClient = new UdpClient(port, AddressFamily.InterNetwork);

            udpClient.JoinMulticastGroup(multicastIp);

            receiveTask = ReceiveMessagesAsync();
        }

        private async Task ReceiveMessagesAsync()
        {
            while (true)
            {
                UdpReceiveResult result = await udpClient.ReceiveAsync();
                string message = Encoding.UTF8.GetString(result.Buffer);
                DisplayMessage($"Received from {result.RemoteEndPoint.Address}: {message}");
            }
        }

        private void DisplayMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(() => DisplayMessage(message));
            }
            else
            {
                chatTextBox.AppendText(message + Environment.NewLine);
            }
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;
            await SendMessageAsync(message);
            DisplayMessage($"Sent: {message}");

            messageTextBox.Clear();
        }

        private async Task SendMessageAsync(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            await udpClient.SendAsync(data, data.Length, new IPEndPoint(multicastIp, port));
        }
    }
}

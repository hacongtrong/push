using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server_congtrong
{
    public partial class Form1 : Form
    {
        TcpListener server;
        IPEndPoint ip;
        Socket socket;
        List<Socket> clientList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void but_send_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientList)
            {
                send(item);
            }
            AddMessage(textBox2.Text);
            textBox2.Clear();
        }

        private void but_opensv_Click(object sender, EventArgs e)
        {
            clientList = new List<Socket>();
            ip = new IPEndPoint(IPAddress.Any, 8000);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            socket.Bind(ip);
            Thread thread = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        socket.Listen(50);
                        Socket client = socket.Accept();
                        clientList.Add(client);
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);

                    }
                }
                catch
                {
                    ip = new IPEndPoint(IPAddress.Any, 8000);
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            MessageBox.Show("Đã mở Server.");
            thread.IsBackground = true;
            thread.Start();
        }
        public void Receive(object ob)
        {
            Socket client = ob as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)deserialize(data);
                    foreach (Socket item in clientList)
                    {
                        if (item != null && item != client)
                        {
                            item.Send(serialize(message));
                        }
                    }
                    AddMessage(message);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }

        public void AddMessage(string str)
        {
            listView1.Items.Add(new ListViewItem() { Text = str });
            textBox2.Clear();
        }

        byte[] serialize(object ob)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, ob);
            return stream.ToArray();
        }

        object deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();
            return bf.Deserialize(stream);
        }

        string gui_txt()
        {
            string s = "";
            string[] line = System.IO.File.ReadAllLines(textBox1.Text);
            foreach (string l in line)
                s += l + "\n";
            return s;

        }
        void send(Socket client)
        {
            if (textBox1.Text != "" && textBox2.Text == "")
                client.Send(serialize("> " + gui_txt()));
            else
                client.Send(serialize("Server: " + textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IPAddress localIP = IPAddress.Parse("127.0.0.1");
            this.run(localIP);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtopen.Text = openFileDialog1.FileName;
        }
        private void run(IPAddress localIp)
        {
            TcpListener tcp = new TcpListener(localIp, int.Parse("6969"));
            tcp.Start();
            for (;;)
            {
                Socket sock = tcp.AcceptSocket();
                if (sock.Connected)
                {
                    sendfiletoClient(sock, txtopen.Text);
                    sock.Close();

                }
                break;
            }
        }
        private void sendfiletoClient(Socket socketforclient, string filepath)
        {
            NetworkStream sstream = new NetworkStream(socketforclient);
            StreamWriter write = new StreamWriter(sstream);
            FileInfo file = new FileInfo(@filepath);
            String theString;
            theString = file.Name;
            if (theString != null)
            {
                MessageBox.Show("Sending ....{0}", theString);

                write.WriteLine(theString);
                write.Flush();

            }

            FileStream tempfile = new FileStream(file.FullName, FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[2560000];
            int byteRead;
            //truyền file bàng nhị phân
            while ((byteRead = tempfile.Read(buffer, 0, 2560000)) > 0)
            {
                sstream.Write(buffer, 0, byteRead);

            }


            tempfile.Close();
            write.Close();

        }
    }
}

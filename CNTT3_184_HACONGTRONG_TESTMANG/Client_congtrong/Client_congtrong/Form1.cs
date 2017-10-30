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

namespace Client_congtrong
{
    public partial class Form1 : Form
    {
        IPEndPoint ip;
        Socket Client;
        static Random radom = new Random();
        string ten = radom.Next().ToString();
        public static string fileRecive = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void but_send_Click(object sender, EventArgs e)
        {
            gui();
            if (txt_value.Text == "GETFILE")
                AddMessage(fileRecive);
            else
                AddMessage(txt_value.Text);
        }

        private void but_connect_Click(object sender, EventArgs e)
        {
            try
            {
                ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000);
                Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                Client.Connect(ip);
                MessageBox.Show("Đã kết nối");
            }
            catch
            {
                MessageBox.Show("Không có kết nối");
                return;
            }
            Thread thread = new Thread(nhan);
            thread.IsBackground = true;
            thread.Start();
        }
        void nhan()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    Client.Receive(data);
                    string message = (string)deserialize(data);
                    if (message[0].ToString() == ">")
                    {
                        fileRecive = message;
                    }
                    else
                        AddMessage(message);
                }
            }
            catch
            {
                Client.Close();
            }
        }

        void AddMessage(string str)
        {
            listView1.Items.Add(new ListViewItem() { Text = str });
            txt_value.Clear();
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

        void gui()
        {
            if (txt_value.Text != string.Empty && txt_value.Text != "GETFILE")
                Client.Send(serialize("Client<" + ten + ">:" + txt_value.Text));
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            string link = "";
            TcpClient socketforserver;
            try
            {
                socketforserver = new TcpClient("127.0.0.1", 6969);
            }
            catch
            {
                MessageBox.Show("Kết nối đến server không thành công");
                return;

            }
            NetworkStream netwwordstream = socketforserver.GetStream();
            StreamReader streamreader = new StreamReader(netwwordstream);
            try
            {
                string outputstring;
                //down file và định dạng
                outputstring = streamreader.ReadLine();
                if (outputstring != null)
                {
                    MessageBox.Show(outputstring);

                }
                link = trvnhan.Text + "/" + outputstring;
                //lưu gile
                FileStream newfile = new FileStream(link, FileMode.OpenOrCreate, FileAccess.Write);
                int byteread; //số bit đọc đc
                byte[] buffer = new byte[256];
                while ((byteread = netwwordstream.Read(buffer, 0, 256)) > 0)
                {
                    newfile.Write(buffer, 0, byteread);
                }
                newfile.Close();
                netwwordstream.Close();

            }
            catch
            {
                MessageBox.Show("Exception reading from server");
                netwwordstream.Close();

            }
            axWindowsMediaPlayer1.URL = link;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            trvnhan.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            trvnhan.Text = openFileDialog1.FileName;
            axWindowsMediaPlayer1.URL = trvnhan.Text;
        }
    }
}

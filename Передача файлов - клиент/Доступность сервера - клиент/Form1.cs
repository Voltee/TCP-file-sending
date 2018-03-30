using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace Доступность_сервера___клиент
{
    public partial class Form1 : Form
    {
       
       
        public SynchronizationContext syncContext;
       public int port;
       public IPAddress ip;
     public string filePath;
        public bool isPathSelected = false,isDone = false;
       public static string sbuf = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ip = IPAddress.Parse(tb_ip.Text);
            port = Convert.ToInt32(tb_port.Text);
            syncContext = SynchronizationContext.Current;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_connect_Click_1(object sender, EventArgs e)
        {
          btn_connect.Enabled = false;
            Thread thread = new Thread(Recieve);
            thread.Start();
            
        }

        void Recieve()
        {
            string s = "";
                
            using (TcpClient client = new TcpClient())
            {
                 client.Connect(ip, port);

                using (NetworkStream stream = client.GetStream())
                {
                    syncContext.Post(post => { lb_status.Text = "Получение файла"; }, null);
                    int count = 1;
                    byte[] buffer = new byte[1024 * 1024];
                    do
                    {

                        count = stream.Read(buffer, 0, buffer.Length);
                        byte[] b = new byte[count];
                        Array.Copy(buffer, 0, b, 0, count);
                        s = Encoding.UTF8.GetString(b);
                        sbuf += s;
                        
                    } while (!s.Contains(@"</Over>"));

                    Console.WriteLine("IT PASSED");

                 
                    syncContext.Post(post => { lb_status.Text = "Отправка ответа"; }, null);

                        string a = "OK";
                        byte[] d = Encoding.UTF8.GetBytes(a);
                         stream.Write(d, 0, d.Length);
                    Thread.Sleep(10);
                    
                }
            }
            syncContext.Post(post => { lb_status.Text = "Создание файла"; }, null);
         
            // создание файла
            if (isPathSelected)
            {
                string packetNum = getString(sbuf, "<NUM/>", "</NUM>");
                string fullpath = filePath +"\\"+ getString(sbuf, "<Name/>", "</Name>");
                string packet =null;
                using (Stream fstream = new FileStream(fullpath, FileMode.Create,FileAccess.Write))
               {
                    
                    
                        for (int i = 0; i < Convert.ToInt16(packetNum); i++)
                        {
                               packet = getString(sbuf,
                               string.Format("<{0}/>", i),
                               string.Format("</{0}>", i));
                         var bytes = StringToByteArray(packet);
                    
                            fstream.Write(bytes,0,bytes.Length);
                        
                        }
                    
                   
                }
            }
            syncContext.Post(post => { lb_status.Text = "Готово"; }, null);
           

        }

        private void btn_choosePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = folderBrowserDialog1.SelectedPath;
                tb_filePath.Text = filePath;
                isPathSelected = true;
            }
        }

        public string getString(string origin, string start, string end)
        {
            Console.WriteLine(origin + " ///ORIGIN");
            Console.WriteLine(start + " ///Start");
            Console.WriteLine(end + " ///END");
            
            string n = origin.Substring(origin.IndexOf(start) + start.Length, origin.LastIndexOf(end) - origin.IndexOf(start) - end.Length);
            Console.WriteLine(n);
            return n;
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
}

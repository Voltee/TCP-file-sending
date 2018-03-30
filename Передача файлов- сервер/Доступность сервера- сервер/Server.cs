using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Linq;
namespace Доступность_сервера__сервер
{
    class Server
    {
        
       public delegate void timeDelegated();
        static public timeDelegated onClientStart;
        static public timeDelegated onClientOver;
        public delegate void messageDelegated(string message);
        static public messageDelegated onClientError;
        static public messageDelegated onClientMessage;
        static public bool isFileChoosen = false;
        public static string FilePath;
        public static string FileName;

        
        int Filesize;
        static bool isDone = false;
        //
        public static void Listen(object port)
        {
            
            try
            {
                List<byte[]> fileBytes = getBytesFromFile(1024*1024);

                var listener = TcpListener.Create(Convert.ToInt16(port));
                listener.Start();
               
                var client =  listener.AcceptTcpClient();
                Form1.syncContext.Post(post => onClientStart(), null);
                
                using (NetworkStream stream = client.GetStream())
                {
                    string s = "<NUM/>" + fileBytes.Count + "</NUM>" + "<Name/>" + FileName + "</Name><Start/>";
                    byte[] data = Encoding.UTF8.GetBytes(s);

                    stream.Write(data, 0, data.Length);
                    //BitConverter.ToString(fileBytes[i]).Replace("-", "")
                    // Encoding.GetEncoding(1251).GetString(fileBytes[i])
                    stream.Flush();
                    for (int i = 0; i < fileBytes.Count; i++)
                    {
                      
                        string mes = string.Format("<{0}/>{1}</{0}>", i, BitConverter.ToString(fileBytes[i]).Replace("-", ""));
                            var mesBytes = Encoding.UTF8.GetBytes(mes);
                            stream.Write(mesBytes, 0, mesBytes.Length);
                        Form1.syncContext.Post(post => onClientMessage(string.Format("{0} - пакетов отправлено из {1}", i , fileBytes.Count)), null);

                    }

                    
                    s = "</Over>";
                    byte[] d = Encoding.UTF8.GetBytes(s);
                   stream.Write(d, 0, d.Length);
                    s = "";
                    byte[] buffer = new byte[200];
                    Thread.Sleep(50);
                    do
                    {

                        int count = stream.Read(buffer, 0, buffer.Length);
                        byte[] b = new byte[count];
                        Array.Copy(buffer, 0, b, 0, count);
                        s += Encoding.UTF8.GetString(b);

                    } while (!s.Contains("OK"));
                    


                }
                Form1.syncContext.Post(post => onClientOver(), null);
                listener.Stop();
                client.Close();
            }
            catch (Exception ex) { Form1.syncContext.Post(post => onClientError(ex.Message), null); }
            
        }


     static public  List<byte[]> getBytesFromFile(int chunkLength)
        {
            List<byte[]> resultBytes = new List<byte[]>();
           
            using (FileStream s = new FileStream(FilePath, FileMode.Open))
            {
                int bytesRead = 1;
                while (bytesRead > 0)
                {
                    byte[] buf = new byte[chunkLength];
                    bytesRead = s.Read(buf, 0, chunkLength);
                    byte[] b = new byte[bytesRead];
                    Array.Copy(buf, 0, b, 0, bytesRead);
                    if (bytesRead != 0)
                    resultBytes.Add(b);
                }
            }

            return resultBytes;
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Timers;

namespace Доступность_сервера__сервер
{
    public partial class Form1 : Form
    {
        DateTime startTime, overTime;
        TimeSpan resultTime;
        Thread mainThread;
       public static SynchronizationContext syncContext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            syncContext = SynchronizationContext.Current;

            Server.onClientStart += onStart;
            Server.onClientOver += onOver;
            Server.onClientError += onError;
            Server.onClientMessage += onRecieved;
            CheckForIllegalCrossThreadCalls = false;
        }

        

        void onOver()
        {
           
            overTime = DateTime.Now;
            resultTime = overTime.Subtract(startTime);
            tb_errorMessage.Text = string.Format("Расчетное время - {0}:{1}:{2}", resultTime.Minutes,resultTime.Seconds,resultTime.Milliseconds);
            lb_state.Text = "Ожидание";
            lb_state.ForeColor = Color.Green;
           // Server.Listen(Convert.ToInt16(tb_port.Text));
        }
        void onStart()
        {
            startTime = DateTime.Now;
            lb_state.Text = "Занят";
            lb_state.ForeColor = Color.Yellow;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(Server.Listen));
            thread.Start(Convert.ToInt16(tb_port.Text));
            btn_start.Enabled = false;
        }

        void onError(string message) {
           
            tb_errorMessage.Text = message;
            lb_state.Text = "Ожидание";
            lb_state.ForeColor = Color.Green;
         
        }

        private void btn_loadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Server.FilePath = openFileDialog1.FileName;
                Server.FileName = openFileDialog1.SafeFileName;
                tb_ref.Text = Server.FilePath;
                Server.isFileChoosen = true;
            }
        }

        void onRecieved(string message)
        {
            tb_client.Text = message;
        }

       
    }
}

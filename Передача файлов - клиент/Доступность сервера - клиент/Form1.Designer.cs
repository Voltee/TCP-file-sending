namespace Доступность_сервера___клиент
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_choosePath = new System.Windows.Forms.Button();
            this.tb_filePath = new System.Windows.Forms.TextBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(12, 12);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(100, 20);
            this.tb_ip.TabIndex = 0;
            this.tb_ip.Text = "127.0.0.1";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(12, 38);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(100, 20);
            this.tb_port.TabIndex = 1;
            this.tb_port.Text = "130";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(12, 131);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(260, 23);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Присоединиться";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click_1);
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(13, 160);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(259, 90);
            this.tb_message.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "port";
            // 
            // btn_choosePath
            // 
            this.btn_choosePath.Location = new System.Drawing.Point(12, 64);
            this.btn_choosePath.Name = "btn_choosePath";
            this.btn_choosePath.Size = new System.Drawing.Size(260, 23);
            this.btn_choosePath.TabIndex = 6;
            this.btn_choosePath.Text = "Выбрать папку для сохранения файла";
            this.btn_choosePath.UseVisualStyleBackColor = true;
            this.btn_choosePath.Click += new System.EventHandler(this.btn_choosePath_Click);
            // 
            // tb_filePath
            // 
            this.tb_filePath.Location = new System.Drawing.Point(13, 93);
            this.tb_filePath.Multiline = true;
            this.tb_filePath.Name = "tb_filePath";
            this.tb_filePath.Size = new System.Drawing.Size(259, 32);
            this.tb_filePath.TabIndex = 7;
            this.tb_filePath.Text = "U:\\BP";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_status.Location = new System.Drawing.Point(159, 15);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(53, 17);
            this.lb_status.TabIndex = 8;
            this.lb_status.Text = "Статус";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.tb_filePath);
            this.Controls.Add(this.btn_choosePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_choosePath;
        private System.Windows.Forms.TextBox tb_filePath;
        private System.Windows.Forms.Label lb_status;
    }
}


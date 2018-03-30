namespace Доступность_сервера__сервер
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
            this.tb_errorMessage = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lb_state = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_loadFile = new System.Windows.Forms.Button();
            this.tb_ref = new System.Windows.Forms.TextBox();
            this.tb_client = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_errorMessage
            // 
            this.tb_errorMessage.Location = new System.Drawing.Point(18, 59);
            this.tb_errorMessage.Multiline = true;
            this.tb_errorMessage.Name = "tb_errorMessage";
            this.tb_errorMessage.Size = new System.Drawing.Size(394, 31);
            this.tb_errorMessage.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(254, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(107, 41);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Запустить сервер";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lb_state
            // 
            this.lb_state.AutoSize = true;
            this.lb_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_state.Location = new System.Drawing.Point(12, 12);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(150, 31);
            this.lb_state.TabIndex = 2;
            this.lb_state.Text = "Состояние";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(368, 32);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(44, 20);
            this.tb_port.TabIndex = 3;
            this.tb_port.Text = "130";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Порт";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_loadFile
            // 
            this.btn_loadFile.Location = new System.Drawing.Point(18, 96);
            this.btn_loadFile.Name = "btn_loadFile";
            this.btn_loadFile.Size = new System.Drawing.Size(164, 41);
            this.btn_loadFile.TabIndex = 5;
            this.btn_loadFile.Text = "Выбрать файл для передачи";
            this.btn_loadFile.UseVisualStyleBackColor = true;
            this.btn_loadFile.Click += new System.EventHandler(this.btn_loadFile_Click);
            // 
            // tb_ref
            // 
            this.tb_ref.Location = new System.Drawing.Point(188, 96);
            this.tb_ref.Multiline = true;
            this.tb_ref.Name = "tb_ref";
            this.tb_ref.Size = new System.Drawing.Size(224, 41);
            this.tb_ref.TabIndex = 6;
            this.tb_ref.Text = "U:\\Texmin-2-й семестр.doc";
            // 
            // tb_client
            // 
            this.tb_client.Location = new System.Drawing.Point(18, 143);
            this.tb_client.Multiline = true;
            this.tb_client.Name = "tb_client";
            this.tb_client.Size = new System.Drawing.Size(394, 21);
            this.tb_client.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 176);
            this.Controls.Add(this.tb_client);
            this.Controls.Add(this.tb_ref);
            this.Controls.Add(this.btn_loadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.lb_state);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.tb_errorMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_errorMessage;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lb_state;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_loadFile;
        private System.Windows.Forms.TextBox tb_ref;
        private System.Windows.Forms.TextBox tb_client;
    }
}


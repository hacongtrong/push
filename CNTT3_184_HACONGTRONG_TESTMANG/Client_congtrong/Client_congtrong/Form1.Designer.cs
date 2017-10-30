namespace Client_congtrong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpen = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.trvnhan = new System.Windows.Forms.TextBox();
            this.btnNhan = new System.Windows.Forms.Button();
            this.but_connect = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.but_send = new System.Windows.Forms.Button();
            this.but_esc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(492, 230);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(79, 28);
            this.btnOpen.TabIndex = 28;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 326);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(481, 175);
            this.axWindowsMediaPlayer1.TabIndex = 29;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(50, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 28);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // trvnhan
            // 
            this.trvnhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvnhan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.trvnhan.Location = new System.Drawing.Point(155, 292);
            this.trvnhan.Multiline = true;
            this.trvnhan.Name = "trvnhan";
            this.trvnhan.Size = new System.Drawing.Size(243, 28);
            this.trvnhan.TabIndex = 26;
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(437, 273);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(94, 47);
            this.btnNhan.TabIndex = 27;
            this.btnNhan.Text = "Nhận";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // but_connect
            // 
            this.but_connect.Location = new System.Drawing.Point(377, 128);
            this.but_connect.Name = "but_connect";
            this.but_connect.Size = new System.Drawing.Size(75, 55);
            this.but_connect.TabIndex = 18;
            this.but_connect.Text = "Kết nối";
            this.but_connect.UseVisualStyleBackColor = true;
            this.but_connect.Click += new System.EventHandler(this.but_connect_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(24, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(347, 207);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(373, 39);
            this.txt_value.Multiline = true;
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(319, 53);
            this.txt_value.TabIndex = 20;
            // 
            // but_send
            // 
            this.but_send.Location = new System.Drawing.Point(594, 128);
            this.but_send.Name = "but_send";
            this.but_send.Size = new System.Drawing.Size(75, 55);
            this.but_send.TabIndex = 21;
            this.but_send.Text = "Gửi";
            this.but_send.UseVisualStyleBackColor = true;
            this.but_send.Click += new System.EventHandler(this.but_send_Click);
            // 
            // but_esc
            // 
            this.but_esc.Location = new System.Drawing.Point(476, 128);
            this.but_esc.Name = "but_esc";
            this.but_esc.Size = new System.Drawing.Size(75, 55);
            this.but_esc.TabIndex = 23;
            this.but_esc.Text = "Thoát";
            this.but_esc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "HÁT CHO NHAU NGHE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 513);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.trvnhan);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.but_esc);
            this.Controls.Add(this.but_send);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.but_connect);
            this.Name = "Form1";
            this.Text = "Client_congtrong";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox trvnhan;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button but_connect;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Button but_send;
        private System.Windows.Forms.Button but_esc;
        private System.Windows.Forms.Label label2;
    }
}


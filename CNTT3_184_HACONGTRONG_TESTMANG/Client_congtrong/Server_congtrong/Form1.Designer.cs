namespace Server_congtrong
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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtopen = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.but_send = new System.Windows.Forms.Button();
            this.but_opensv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtopen
            // 
            this.txtopen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtopen.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtopen.Location = new System.Drawing.Point(379, 125);
            this.txtopen.Multiline = true;
            this.txtopen.Name = "txtopen";
            this.txtopen.Size = new System.Drawing.Size(243, 28);
            this.txtopen.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 22;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(321, 20);
            this.textBox1.TabIndex = 18;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(347, 207);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 305);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 53);
            this.textBox2.TabIndex = 15;
            // 
            // but_send
            // 
            this.but_send.Location = new System.Drawing.Point(365, 303);
            this.but_send.Name = "but_send";
            this.but_send.Size = new System.Drawing.Size(75, 55);
            this.but_send.TabIndex = 16;
            this.but_send.Text = "Gửi";
            this.but_send.UseVisualStyleBackColor = true;
            this.but_send.Click += new System.EventHandler(this.but_send_Click);
            // 
            // but_opensv
            // 
            this.but_opensv.Location = new System.Drawing.Point(12, 11);
            this.but_opensv.Name = "but_opensv";
            this.but_opensv.Size = new System.Drawing.Size(75, 23);
            this.but_opensv.TabIndex = 17;
            this.but_opensv.Text = "Mở server";
            this.but_opensv.UseVisualStyleBackColor = true;
            this.but_opensv.Click += new System.EventHandler(this.but_opensv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtopen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.but_opensv);
            this.Controls.Add(this.but_send);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Server_congtrong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtopen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button but_send;
        private System.Windows.Forms.Button but_opensv;
    }
}


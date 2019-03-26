namespace Lab_5_RSA
{
    partial class View
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sms_text_box = new System.Windows.Forms.TextBox();
            this.Q_text_Box = new System.Windows.Forms.TextBox();
            this.N_text_box = new System.Windows.Forms.TextBox();
            this.P_text_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.E_text_box = new System.Windows.Forms.TextBox();
            this.D_text_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.End_text_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.crypt_text_box = new System.Windows.Forms.TextBox();
            this.btn_DeEncrypt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sms_text_box);
            this.panel1.Controls.Add(this.Q_text_Box);
            this.panel1.Controls.Add(this.N_text_box);
            this.panel1.Controls.Add(this.P_text_Box);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.E_text_box);
            this.panel1.Controls.Add(this.D_text_Box);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_Encrypt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 94);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введите:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(80, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Смс для шифровки:";
            // 
            // sms_text_box
            // 
            this.sms_text_box.Location = new System.Drawing.Point(100, 28);
            this.sms_text_box.Name = "sms_text_box";
            this.sms_text_box.Size = new System.Drawing.Size(100, 20);
            this.sms_text_box.TabIndex = 10;
            // 
            // Q_text_Box
            // 
            this.Q_text_Box.Location = new System.Drawing.Point(37, 54);
            this.Q_text_Box.Name = "Q_text_Box";
            this.Q_text_Box.Size = new System.Drawing.Size(46, 20);
            this.Q_text_Box.TabIndex = 8;
            // 
            // N_text_box
            // 
            this.N_text_box.Enabled = false;
            this.N_text_box.Location = new System.Drawing.Point(235, 62);
            this.N_text_box.Name = "N_text_box";
            this.N_text_box.Size = new System.Drawing.Size(46, 20);
            this.N_text_box.TabIndex = 9;
            // 
            // P_text_Box
            // 
            this.P_text_Box.Location = new System.Drawing.Point(37, 32);
            this.P_text_Box.Name = "P_text_Box";
            this.P_text_Box.Size = new System.Drawing.Size(46, 20);
            this.P_text_Box.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Q";
            // 
            // E_text_box
            // 
            this.E_text_box.Enabled = false;
            this.E_text_box.Location = new System.Drawing.Point(235, 40);
            this.E_text_box.Name = "E_text_box";
            this.E_text_box.Size = new System.Drawing.Size(46, 20);
            this.E_text_box.TabIndex = 9;
            // 
            // D_text_Box
            // 
            this.D_text_Box.Enabled = false;
            this.D_text_Box.Location = new System.Drawing.Point(235, 18);
            this.D_text_Box.Name = "D_text_Box";
            this.D_text_Box.Size = new System.Drawing.Size(46, 20);
            this.D_text_Box.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "P";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(221, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "N";
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Encrypt.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Encrypt.Location = new System.Drawing.Point(95, 54);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(109, 29);
            this.btn_Encrypt.TabIndex = 5;
            this.btn_Encrypt.Text = "Зашифровать";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(221, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "D";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(221, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "E";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 94);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(291, 95);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.End_text_box);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.crypt_text_box);
            this.panel2.Controls.Add(this.btn_DeEncrypt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 86);
            this.panel2.TabIndex = 7;
            // 
            // End_text_box
            // 
            this.End_text_box.Location = new System.Drawing.Point(157, 36);
            this.End_text_box.Name = "End_text_box";
            this.End_text_box.Size = new System.Drawing.Size(113, 20);
            this.End_text_box.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(161, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Расшифровка:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Зашифрованное смс:";
            // 
            // crypt_text_box
            // 
            this.crypt_text_box.Location = new System.Drawing.Point(20, 18);
            this.crypt_text_box.Name = "crypt_text_box";
            this.crypt_text_box.Size = new System.Drawing.Size(100, 20);
            this.crypt_text_box.TabIndex = 12;
            // 
            // btn_DeEncrypt
            // 
            this.btn_DeEncrypt.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_DeEncrypt.Location = new System.Drawing.Point(20, 44);
            this.btn_DeEncrypt.Name = "btn_DeEncrypt";
            this.btn_DeEncrypt.Size = new System.Drawing.Size(100, 29);
            this.btn_DeEncrypt.TabIndex = 11;
            this.btn_DeEncrypt.Text = "Расшифровать";
            this.btn_DeEncrypt.UseVisualStyleBackColor = true;
            this.btn_DeEncrypt.Click += new System.EventHandler(this.btn_DeEncrypt_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 189);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab_6_RSA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sms_text_box;
        private System.Windows.Forms.TextBox Q_text_Box;
        private System.Windows.Forms.TextBox P_text_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox crypt_text_box;
        private System.Windows.Forms.Button btn_DeEncrypt;
        private System.Windows.Forms.TextBox End_text_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox D_text_Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox E_text_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox N_text_box;
        private System.Windows.Forms.Label label9;
    }
}


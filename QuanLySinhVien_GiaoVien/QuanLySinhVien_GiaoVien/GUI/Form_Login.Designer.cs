namespace QuanLySinhVien_GiaoVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_Login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tx_Password = new System.Windows.Forms.TextBox();
            this.tx_user = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".VnVogueH", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "welcome to login";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.bt_Login);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.tx_Password);
            this.groupBox1.Controls.Add(this.tx_user);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 401);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(189, 311);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 16);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu ?";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.panel4.BackgroundImage = global::QuanLySinhVien_GiaoVien.Properties.Resources.user_24;
            this.panel4.Location = new System.Drawing.Point(4, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 24);
            this.panel4.TabIndex = 9;
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.bt_Login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.ForeColor = System.Drawing.Color.White;
            this.bt_Login.Location = new System.Drawing.Point(14, 246);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(282, 40);
            this.bt_Login.TabIndex = 5;
            this.bt_Login.Text = "Đăng Nhập";
            this.bt_Login.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(86)))), ((int)(((byte)(157)))));
            this.panel2.BackgroundImage = global::QuanLySinhVien_GiaoVien.Properties.Resources.key_4_24;
            this.panel2.Location = new System.Drawing.Point(4, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 24);
            this.panel2.TabIndex = 4;
            // 
            // tx_Password
            // 
            this.tx_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Password.Location = new System.Drawing.Point(31, 181);
            this.tx_Password.Name = "tx_Password";
            this.tx_Password.Size = new System.Drawing.Size(275, 29);
            this.tx_Password.TabIndex = 2;
            this.tx_Password.UseSystemPasswordChar = true;
            // 
            // tx_user
            // 
            this.tx_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_user.Location = new System.Drawing.Point(29, 135);
            this.tx_user.Name = "tx_user";
            this.tx_user.Size = new System.Drawing.Size(275, 29);
            this.tx_user.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(221, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 401);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(22, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 24);
            this.panel3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySinhVien_GiaoVien.Properties.Resources._0071___b4KrxJ5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 511);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tx_Password;
        private System.Windows.Forms.TextBox tx_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}


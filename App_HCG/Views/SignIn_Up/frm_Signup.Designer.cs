namespace App_HCG.Views.SignIn_Up
{
    partial class frm_Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Signup));
            this.btn_signIn = new System.Windows.Forms.Button();
            this.grp_dangnhap = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_retype = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.grp_dangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_signIn
            // 
            this.btn_signIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signIn.Location = new System.Drawing.Point(587, 421);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(162, 38);
            this.btn_signIn.TabIndex = 12;
            this.btn_signIn.Text = "Đăng nhập";
            this.btn_signIn.UseVisualStyleBackColor = true;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // grp_dangnhap
            // 
            this.grp_dangnhap.Controls.Add(this.txt_username);
            this.grp_dangnhap.Controls.Add(this.txt_password);
            this.grp_dangnhap.Controls.Add(this.label2);
            this.grp_dangnhap.Controls.Add(this.btn_signIn);
            this.grp_dangnhap.Controls.Add(this.label4);
            this.grp_dangnhap.Controls.Add(this.txt_retype);
            this.grp_dangnhap.Controls.Add(this.label5);
            this.grp_dangnhap.Controls.Add(this.label3);
            this.grp_dangnhap.Controls.Add(this.pictureBox1);
            this.grp_dangnhap.Controls.Add(this.btn_signUp);
            this.grp_dangnhap.Controls.Add(this.txt_name);
            this.grp_dangnhap.Controls.Add(this.label1);
            this.grp_dangnhap.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_dangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.grp_dangnhap.Location = new System.Drawing.Point(317, 117);
            this.grp_dangnhap.Name = "grp_dangnhap";
            this.grp_dangnhap.Size = new System.Drawing.Size(882, 575);
            this.grp_dangnhap.TabIndex = 10;
            this.grp_dangnhap.TabStop = false;
            this.grp_dangnhap.Text = "Đăng ký hệ thống";
            this.grp_dangnhap.Enter += new System.EventHandler(this.grp_dangnhap_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bạn đã có tài khoản?";
            // 
            // txt_retype
            // 
            this.txt_retype.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_retype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_retype.Location = new System.Drawing.Point(337, 346);
            this.txt_retype.Name = "txt_retype";
            this.txt_retype.Size = new System.Drawing.Size(471, 39);
            this.txt_retype.TabIndex = 9;
            this.txt_retype.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhập lại mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tài khoản:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_HCG.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(59, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_signUp
            // 
            this.btn_signUp.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signUp.Location = new System.Drawing.Point(337, 483);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(471, 48);
            this.btn_signUp.TabIndex = 3;
            this.btn_signUp.Text = "Đăng ký";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_name.Location = new System.Drawing.Point(337, 89);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(471, 39);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_password.Location = new System.Drawing.Point(337, 260);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(471, 39);
            this.txt_password.TabIndex = 13;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mật khẩu:";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_username.Location = new System.Drawing.Point(337, 174);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(471, 39);
            this.txt_username.TabIndex = 15;
            // 
            // frm_Signup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1517, 808);
            this.Controls.Add(this.grp_dangnhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Signup";
            this.Text = "Đăng ký";
            this.grp_dangnhap.ResumeLayout(false);
            this.grp_dangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.GroupBox grp_dangnhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_retype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
    }
}
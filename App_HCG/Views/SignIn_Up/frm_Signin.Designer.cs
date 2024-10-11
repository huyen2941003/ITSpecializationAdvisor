namespace App_HCG.Views.SignIn_Up
{
    partial class frm_Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Signin));
            this.btn_signIn = new System.Windows.Forms.Button();
            this.grp_dangnhap = new System.Windows.Forms.GroupBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp_dangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_signIn
            // 
            this.btn_signIn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signIn.Location = new System.Drawing.Point(210, 476);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(471, 48);
            this.btn_signIn.TabIndex = 3;
            this.btn_signIn.Text = "Đăng nhập";
            this.btn_signIn.UseVisualStyleBackColor = true;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // grp_dangnhap
            // 
            this.grp_dangnhap.Controls.Add(this.pictureBox1);
            this.grp_dangnhap.Controls.Add(this.btn_signIn);
            this.grp_dangnhap.Controls.Add(this.txt_password);
            this.grp_dangnhap.Controls.Add(this.label2);
            this.grp_dangnhap.Controls.Add(this.txt_user);
            this.grp_dangnhap.Controls.Add(this.label1);
            this.grp_dangnhap.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_dangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.grp_dangnhap.Location = new System.Drawing.Point(335, 119);
            this.grp_dangnhap.Name = "grp_dangnhap";
            this.grp_dangnhap.Size = new System.Drawing.Size(882, 575);
            this.grp_dangnhap.TabIndex = 10;
            this.grp_dangnhap.TabStop = false;
            this.grp_dangnhap.Text = "Đăng nhập hệ thống";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_password.Location = new System.Drawing.Point(210, 412);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(471, 39);
            this.txt_password.TabIndex = 2;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_user.Location = new System.Drawing.Point(210, 329);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(471, 39);
            this.txt_user.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_HCG.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(328, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Signin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1517, 808);
            this.Controls.Add(this.grp_dangnhap);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Signin";
            this.Text = "Đăng nhập";
            this.grp_dangnhap.ResumeLayout(false);
            this.grp_dangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.GroupBox grp_dangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label1;
    }
}
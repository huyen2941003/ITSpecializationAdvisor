namespace App_HCG.Views.Admin
{
    partial class Advisor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_preference = new System.Windows.Forms.DataGridView();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_huytat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grp_yesno = new System.Windows.Forms.GroupBox();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.txt_preferences = new System.Windows.Forms.TextBox();
            this.btn_advisor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_majors = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_explain = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_preference)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp_yesno.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgv_preference);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.groupBox2.Location = new System.Drawing.Point(24, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 728);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sở thích";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_search.Location = new System.Drawing.Point(126, 33);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(452, 34);
            this.txt_search.TabIndex = 41;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tìm kiếm:";
            // 
            // dgv_preference
            // 
            this.dgv_preference.BackgroundColor = System.Drawing.Color.White;
            this.dgv_preference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_preference.Location = new System.Drawing.Point(27, 88);
            this.dgv_preference.Name = "dgv_preference";
            this.dgv_preference.RowHeadersWidth = 51;
            this.dgv_preference.RowTemplate.Height = 24;
            this.dgv_preference.Size = new System.Drawing.Size(551, 621);
            this.dgv_preference.TabIndex = 1;
            this.dgv_preference.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_preference_CellClick);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(676, 233);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(218, 48);
            this.btn_huy.TabIndex = 29;
            this.btn_huy.Text = "< Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_huytat
            // 
            this.btn_huytat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huytat.Location = new System.Drawing.Point(676, 297);
            this.btn_huytat.Name = "btn_huytat";
            this.btn_huytat.Size = new System.Drawing.Size(218, 48);
            this.btn_huytat.TabIndex = 30;
            this.btn_huytat.Text = "<< Hủy tất";
            this.btn_huytat.UseVisualStyleBackColor = true;
            this.btn_huytat.Click += new System.EventHandler(this.btn_huytat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grp_yesno);
            this.groupBox1.Controls.Add(this.txt_preferences);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.groupBox1.Location = new System.Drawing.Point(947, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 369);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các dữ kiện";
            // 
            // grp_yesno
            // 
            this.grp_yesno.Controls.Add(this.btn_yes);
            this.grp_yesno.Controls.Add(this.btn_no);
            this.grp_yesno.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_yesno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.grp_yesno.Location = new System.Drawing.Point(24, 248);
            this.grp_yesno.Name = "grp_yesno";
            this.grp_yesno.Size = new System.Drawing.Size(500, 101);
            this.grp_yesno.TabIndex = 47;
            this.grp_yesno.TabStop = false;
            // 
            // btn_yes
            // 
            this.btn_yes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yes.Location = new System.Drawing.Point(71, 39);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(173, 43);
            this.btn_yes.TabIndex = 32;
            this.btn_yes.Text = "Có";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_no
            // 
            this.btn_no.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.Location = new System.Drawing.Point(274, 39);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(173, 43);
            this.btn_no.TabIndex = 31;
            this.btn_no.Text = "Không";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // txt_preferences
            // 
            this.txt_preferences.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preferences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_preferences.Location = new System.Drawing.Point(24, 33);
            this.txt_preferences.Multiline = true;
            this.txt_preferences.Name = "txt_preferences";
            this.txt_preferences.Size = new System.Drawing.Size(500, 198);
            this.txt_preferences.TabIndex = 46;
            // 
            // btn_advisor
            // 
            this.btn_advisor.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_advisor.Location = new System.Drawing.Point(1106, 407);
            this.btn_advisor.Name = "btn_advisor";
            this.btn_advisor.Size = new System.Drawing.Size(218, 48);
            this.btn_advisor.TabIndex = 31;
            this.btn_advisor.Text = "Tư vấn";
            this.btn_advisor.UseVisualStyleBackColor = true;
            this.btn_advisor.Click += new System.EventHandler(this.btn_advisor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_majors);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.groupBox3.Location = new System.Drawing.Point(676, 461);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(818, 89);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chuyên ngành mà bạn phù hợp";
            // 
            // txt_majors
            // 
            this.txt_majors.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_majors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_majors.Location = new System.Drawing.Point(24, 33);
            this.txt_majors.Multiline = true;
            this.txt_majors.Name = "txt_majors";
            this.txt_majors.Size = new System.Drawing.Size(771, 41);
            this.txt_majors.TabIndex = 46;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_explain);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.groupBox4.Location = new System.Drawing.Point(676, 556);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(818, 192);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giải thích";
            // 
            // txt_explain
            // 
            this.txt_explain.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_explain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_explain.Location = new System.Drawing.Point(24, 33);
            this.txt_explain.Multiline = true;
            this.txt_explain.Name = "txt_explain";
            this.txt_explain.Size = new System.Drawing.Size(771, 140);
            this.txt_explain.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_HCG.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(700, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // Advisor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_advisor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_huytat);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.groupBox2);
            this.Name = "Advisor";
            this.Size = new System.Drawing.Size(1517, 768);
            this.Load += new System.EventHandler(this.Advisor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_preference)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_yesno.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_preference;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_huytat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_preferences;
        private System.Windows.Forms.Button btn_advisor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_majors;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_explain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grp_yesno;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_no;
    }
}

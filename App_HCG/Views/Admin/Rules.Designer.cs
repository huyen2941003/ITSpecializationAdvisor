namespace App_HCG.Views.Admin
{
    partial class Rules
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
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.dgv_majors = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_rules = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_preference = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insertPre = new System.Windows.Forms.Button();
            this.btn_insertMajors = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.grp_yesno = new System.Windows.Forms.GroupBox();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.txt_right = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_left = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_majors)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rules)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_preference)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grp_yesno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.dgv_majors);
            this.grpbox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.grpbox.Location = new System.Drawing.Point(590, 527);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(555, 230);
            this.grpbox.TabIndex = 19;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Chuyên ngành";
            // 
            // dgv_majors
            // 
            this.dgv_majors.BackgroundColor = System.Drawing.Color.White;
            this.dgv_majors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_majors.Location = new System.Drawing.Point(27, 33);
            this.dgv_majors.Name = "dgv_majors";
            this.dgv_majors.RowHeadersWidth = 51;
            this.dgv_majors.RowTemplate.Height = 24;
            this.dgv_majors.Size = new System.Drawing.Size(505, 179);
            this.dgv_majors.TabIndex = 1;
            this.dgv_majors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_majors_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_rules);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.groupBox1.Location = new System.Drawing.Point(20, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 437);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách luật";
            // 
            // dgv_rules
            // 
            this.dgv_rules.BackgroundColor = System.Drawing.Color.White;
            this.dgv_rules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rules.Location = new System.Drawing.Point(27, 33);
            this.dgv_rules.Name = "dgv_rules";
            this.dgv_rules.RowHeadersWidth = 51;
            this.dgv_rules.RowTemplate.Height = 24;
            this.dgv_rules.Size = new System.Drawing.Size(505, 386);
            this.dgv_rules.TabIndex = 1;
            this.dgv_rules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rules_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_preference);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.groupBox2.Location = new System.Drawing.Point(20, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 298);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sở thích";
            // 
            // dgv_preference
            // 
            this.dgv_preference.BackgroundColor = System.Drawing.Color.White;
            this.dgv_preference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_preference.Location = new System.Drawing.Point(27, 33);
            this.dgv_preference.Name = "dgv_preference";
            this.dgv_preference.RowHeadersWidth = 51;
            this.dgv_preference.RowTemplate.Height = 24;
            this.dgv_preference.Size = new System.Drawing.Size(505, 248);
            this.dgv_preference.TabIndex = 1;
            this.dgv_preference.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_preference_CellClick);
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(1212, 588);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(117, 48);
            this.btn_insert.TabIndex = 22;
            this.btn_insert.Text = "Thêm";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(1362, 588);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(117, 48);
            this.btn_update.TabIndex = 23;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(1362, 664);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(117, 48);
            this.btn_reset.TabIndex = 25;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(1212, 664);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 48);
            this.btn_delete.TabIndex = 24;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insertPre
            // 
            this.btn_insertPre.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertPre.Location = new System.Drawing.Point(627, 290);
            this.btn_insertPre.Name = "btn_insertPre";
            this.btn_insertPre.Size = new System.Drawing.Size(240, 48);
            this.btn_insertPre.TabIndex = 26;
            this.btn_insertPre.Text = "Chọn vế trái >>";
            this.btn_insertPre.UseVisualStyleBackColor = true;
            // 
            // btn_insertMajors
            // 
            this.btn_insertMajors.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertMajors.Location = new System.Drawing.Point(627, 355);
            this.btn_insertMajors.Name = "btn_insertMajors";
            this.btn_insertMajors.Size = new System.Drawing.Size(240, 48);
            this.btn_insertMajors.TabIndex = 27;
            this.btn_insertMajors.Text = "Chọn vế phải >>";
            this.btn_insertMajors.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_des);
            this.groupBox3.Controls.Add(this.grp_yesno);
            this.groupBox3.Controls.Add(this.txt_right);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_left);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.groupBox3.Location = new System.Drawing.Point(911, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 505);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết luật";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 46;
            this.label4.Text = "Mô tả:";
            // 
            // txt_des
            // 
            this.txt_des.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_des.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_des.Location = new System.Drawing.Point(131, 348);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(422, 135);
            this.txt_des.TabIndex = 45;
            // 
            // grp_yesno
            // 
            this.grp_yesno.Controls.Add(this.btn_yes);
            this.grp_yesno.Controls.Add(this.btn_no);
            this.grp_yesno.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_yesno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.grp_yesno.Location = new System.Drawing.Point(38, 161);
            this.grp_yesno.Name = "grp_yesno";
            this.grp_yesno.Size = new System.Drawing.Size(515, 101);
            this.grp_yesno.TabIndex = 44;
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
            // txt_right
            // 
            this.txt_right.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_right.Location = new System.Drawing.Point(131, 283);
            this.txt_right.Name = "txt_right";
            this.txt_right.Size = new System.Drawing.Size(422, 34);
            this.txt_right.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 42;
            this.label3.Text = "Vế phải:";
            // 
            // txt_left
            // 
            this.txt_left.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_left.Location = new System.Drawing.Point(131, 112);
            this.txt_left.Name = "txt_left";
            this.txt_left.Size = new System.Drawing.Size(422, 34);
            this.txt_left.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "Vế trái:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_id.Location = new System.Drawing.Point(131, 47);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(422, 34);
            this.txt_id.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã luật:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_HCG.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(627, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(627, 421);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(240, 48);
            this.btn_huy.TabIndex = 29;
            this.btn_huy.Text = "<< Hủy bỏ";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // Rules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_insertMajors);
            this.Controls.Add(this.btn_insertPre);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbox);
            this.Name = "Rules";
            this.Size = new System.Drawing.Size(1517, 768);
            this.Load += new System.EventHandler(this.Rules_Load);
            this.grpbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_majors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rules)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_preference)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grp_yesno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.DataGridView dgv_majors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_rules;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_preference;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insertPre;
        private System.Windows.Forms.Button btn_insertMajors;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_right;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_yesno;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_huy;
    }
}

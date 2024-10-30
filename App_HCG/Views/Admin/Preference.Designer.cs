namespace App_HCG.Views.Admin
{
    partial class Preference
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
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.dgv_preference = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.cmb_majors = new System.Windows.Forms.ComboBox();
            this.grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_preference)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(942, 619);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(185, 48);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(1173, 551);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(185, 48);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(1173, 619);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(185, 48);
            this.btn_reset.TabIndex = 19;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.dgv_preference);
            this.grpbox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.grpbox.Location = new System.Drawing.Point(86, 44);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(731, 680);
            this.grpbox.TabIndex = 18;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Sở thích";
            // 
            // dgv_preference
            // 
            this.dgv_preference.BackgroundColor = System.Drawing.Color.White;
            this.dgv_preference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_preference.Location = new System.Drawing.Point(27, 46);
            this.dgv_preference.Name = "dgv_preference";
            this.dgv_preference.RowHeadersWidth = 51;
            this.dgv_preference.RowTemplate.Height = 24;
            this.dgv_preference.Size = new System.Drawing.Size(682, 608);
            this.dgv_preference.TabIndex = 1;
            this.dgv_preference.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_preference_CellClick);
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(942, 551);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(185, 48);
            this.btn_insert.TabIndex = 17;
            this.btn_insert.Text = "Thêm";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_des
            // 
            this.txt_des.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_des.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_des.Location = new System.Drawing.Point(893, 225);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(515, 180);
            this.txt_des.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(893, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(893, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 33);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mã chuyên ngành:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_id.Location = new System.Drawing.Point(893, 130);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(515, 39);
            this.txt_id.TabIndex = 37;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(893, 425);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(265, 33);
            this.label.TabIndex = 38;
            this.label.Text = "Chuyên ngành đi kèm:";
            // 
            // cmb_majors
            // 
            this.cmb_majors.BackColor = System.Drawing.Color.White;
            this.cmb_majors.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_majors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.cmb_majors.FormattingEnabled = true;
            this.cmb_majors.Location = new System.Drawing.Point(893, 461);
            this.cmb_majors.Name = "cmb_majors";
            this.cmb_majors.Size = new System.Drawing.Size(515, 39);
            this.cmb_majors.TabIndex = 39;
            // 
            // Preference
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmb_majors);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.btn_insert);
            this.Name = "Preference";
            this.Size = new System.Drawing.Size(1517, 768);
            this.Load += new System.EventHandler(this.Preference_Load);
            this.grpbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_preference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.DataGridView dgv_preference;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cmb_majors;
    }
}

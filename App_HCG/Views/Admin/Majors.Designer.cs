namespace App_HCG.Views.Admin
{
    partial class Majors
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
            this.dgv_majors = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_majors)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(952, 670);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(185, 48);
            this.btn_update.TabIndex = 30;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(1183, 615);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(185, 48);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(1183, 670);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(185, 48);
            this.btn_reset.TabIndex = 28;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.dgv_majors);
            this.grpbox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.grpbox.Location = new System.Drawing.Point(97, 44);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(731, 680);
            this.grpbox.TabIndex = 27;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Chuyên ngành";
            // 
            // dgv_majors
            // 
            this.dgv_majors.BackgroundColor = System.Drawing.Color.White;
            this.dgv_majors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_majors.Location = new System.Drawing.Point(27, 44);
            this.dgv_majors.Name = "dgv_majors";
            this.dgv_majors.RowHeadersWidth = 51;
            this.dgv_majors.RowTemplate.Height = 24;
            this.dgv_majors.Size = new System.Drawing.Size(682, 610);
            this.dgv_majors.TabIndex = 1;
            this.dgv_majors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_majors_CellClick);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_name.Location = new System.Drawing.Point(898, 230);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(515, 39);
            this.txt_name.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(892, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tên:";
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(952, 615);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(185, 48);
            this.btn_insert.TabIndex = 26;
            this.btn_insert.Text = "Thêm";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_des
            // 
            this.txt_des.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_des.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_des.Location = new System.Drawing.Point(898, 330);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(515, 268);
            this.txt_des.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(892, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mô tả:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_id.Location = new System.Drawing.Point(898, 135);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(515, 39);
            this.txt_id.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(898, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 33);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã chuyên ngành:";
            // 
            // Majors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_insert);
            this.Name = "Majors";
            this.Size = new System.Drawing.Size(1517, 768);
            this.Load += new System.EventHandler(this.Majors_Load);
            this.grpbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_majors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.DataGridView dgv_majors;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
    }
}

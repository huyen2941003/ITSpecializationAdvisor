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
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.dgv_preference);
            this.grpbox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgv_preference.Location = new System.Drawing.Point(27, 62);
            this.dgv_preference.Name = "dgv_preference";
            this.dgv_preference.RowHeadersWidth = 51;
            this.dgv_preference.RowTemplate.Height = 24;
            this.dgv_preference.Size = new System.Drawing.Size(682, 592);
            this.dgv_preference.TabIndex = 1;
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
            // 
            // txt_des
            // 
            this.txt_des.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_des.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(83)))));
            this.txt_des.Location = new System.Drawing.Point(893, 217);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(515, 307);
            this.txt_des.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(887, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mô tả:";
            // 
            // Preference
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.btn_insert);
            this.Name = "Preference";
            this.Size = new System.Drawing.Size(1517, 768);
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
    }
}

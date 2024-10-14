using App_HCG.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_HCG.Views.Admin
{
    public partial class Majors : UserControl
    {
        public Majors()
        {
            InitializeComponent();
            txt_id.Enabled = false;
        }
        void Clear()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_des.Text = "";

            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_insert.Enabled = true;
        }
        private void Majors_Load(object sender, EventArgs e)
        {
            dgv_majors.DataSource = MajorsDAO.Instance.getlistMajors();
            dgv_majors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_majors.ReadOnly = true;

            dgv_majors.Columns["id"].HeaderText = "Mã chuyên ngành";
            dgv_majors.Columns["name"].HeaderText = "Tên";
            dgv_majors.Columns["description"].HeaderText = "Mô tả";

            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_insert.Enabled = true;
        }
        private void dgv_majors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txt_id.Text = dgv_majors.Rows[r].Cells["id"].Value.ToString();
                txt_name.Text = dgv_majors.Rows[r].Cells["name"].Value.ToString();
                txt_des.Text = dgv_majors.Rows[r].Cells["description"].Value.ToString();

                btn_delete.Enabled = true;
                btn_update.Enabled = true;
                btn_insert.Enabled = false;
            }
        }
        bool InsertMajors(string name, string description)
        {
            return MajorsDAO.Instance.InsertMajors(name, description);
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string description = txt_des.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                if (InsertMajors(name, description))
                {
                    MessageBox.Show("Thêm thành công!");
                    btn_reset.PerformClick();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại, vui lòng kiểm tra lại dữ liệu!");
                }
            }
        }
        bool DeleteMajors(string id)
        {
            return MajorsDAO.Instance.DeleteMajors(id);
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string iD = txt_id.Text;
            /*if (MajorsDAO.Instance.s(iD).Count > 0)
            {
                MessageBox.Show("Không được xóa nhân viên này!");
            }
            else
            {*/
                if (DeleteMajors(iD))
                {
                    MessageBox.Show("Xóa thành công!");
                    btn_reset.PerformClick();
            }
            else
                {
                    MessageBox.Show("Xóa thất bại, vui lòng kiểm tra lại dữ liệu!");
                }
        }
        bool UpdateMajors(string iD, string name, string description)
        {
            return MajorsDAO.Instance.UpdateMajors(iD, name, description);
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string name = txt_name.Text;
            string description = txt_des.Text;
            if (UpdateMajors(id, name, description))
            {
                MessageBox.Show("Sửa thành công!");
                btn_reset.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại, vui lòng kiểm tra lại dữ liệu!");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Clear();
            dgv_majors.DataSource = MajorsDAO.Instance.getlistMajors();
        }
    }
}

﻿using App_HCG.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_HCG.Views.Admin
{
    public partial class Preference : UserControl
    {
        public Preference()
        {
            InitializeComponent();
            txt_id.Enabled = false;
            LoadCmb();
        }
        void LoadCmb()
        {
            List<DTO.Majors> majors = MajorsDAO.Instance.getlistMajors();
            cmb_majors.DataSource = majors;
            cmb_majors.DisplayMember = "name";
        }
        void Clear()
        {
            txt_id.Text = "";
            txt_des.Text = "";

            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_insert.Enabled = true;
        }
        private void Preference_Load(object sender, EventArgs e)
        {
            dgv_preference.DataSource = PreferenceDAO.Instance.getlistPreferences2();
            dgv_preference.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_preference.ReadOnly = true;

            dgv_preference.Columns["id"].HeaderText = "Mã Sở thích";
            dgv_preference.Columns["description"].HeaderText = "Mô tả";
            dgv_preference.Columns["id_majors"].HeaderText = "Chuyên ngành";

            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_insert.Enabled = true;
        }
        private void dgv_preference_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txt_id.Text = dgv_preference.Rows[r].Cells["id"].Value.ToString();
                txt_des.Text = dgv_preference.Rows[r].Cells["description"].Value.ToString();
                cmb_majors.SelectedIndex = cmb_majors.FindString(dgv_preference.Rows[r].Cells["id_majors"].Value.ToString());

                btn_delete.Enabled = true;
                btn_update.Enabled = true;
                btn_insert.Enabled = false;
            }
        }
        bool InsertPreference(string description, string id_majors)
        {
            return PreferenceDAO.Instance.InsertPreferences(description, id_majors);
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            string description = txt_des.Text;
            string id_majors = ((DTO.Majors)cmb_majors.SelectedItem).Name;

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                if (InsertPreference(description, id_majors))
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
        bool DeletePreference(string id)
        {
            return PreferenceDAO.Instance.DeletePreferences(id);
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string iD = txt_id.Text;
            /*if (PreferenceDAO.Instance.s(iD).Count > 0)
            {
                MessageBox.Show("Không được xóa!");
            }
            else
            {*/
            if (DeletePreference(iD))
            {
                MessageBox.Show("Xóa thành công!");
                btn_reset.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại, vui lòng kiểm tra lại dữ liệu!");
            }
        }
        bool UpdatePreference(string iD, string description, string id_majors)
        {
            return PreferenceDAO.Instance.UpdatePreferences(iD, description, id_majors);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string description = txt_des.Text;
            string id_majors = ((DTO.Majors)cmb_majors.SelectedItem).Name;

            if (UpdatePreference(id, description, id_majors))
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
            dgv_preference.DataSource = PreferenceDAO.Instance.getlistPreferences2();
        }
    }
}

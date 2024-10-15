using App_HCG.DAO;
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
    public partial class Rules : UserControl
    {
        public Rules()
        {
            InitializeComponent();
            txt_id.Enabled = false;
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            dgv_preference.DataSource = PreferenceDAO.Instance.getlistPreferences();
            dgv_preference.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_preference.ReadOnly = true;
            dgv_preference.Columns["id"].HeaderText = "Mã chuyên ngành";
            dgv_preference.Columns["description"].HeaderText = "Mô tả";

            dgv_majors.DataSource = MajorsDAO.Instance.getlistMajors();
            dgv_majors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_majors.ReadOnly = true;
            dgv_majors.Columns["id"].HeaderText = "Mã chuyên ngành";
            dgv_majors.Columns["name"].HeaderText = "Tên";
            dgv_majors.Columns["description"].HeaderText = "Mô tả";

            dgv_rules.DataSource = RulesDAO.Instance.getlistRules();
            dgv_rules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_rules.ReadOnly = true;
            dgv_rules.Columns["id"].HeaderText = "Mã chuyên ngành";
            dgv_rules.Columns["ruleS"].HeaderText = "Luật";
            dgv_rules.Columns["id_Majors"].HeaderText = "Kết quả";
            dgv_rules.Columns["description"].HeaderText = "Mô tả";

        }

        private void dgv_rules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txt_id.Text = dgv_rules.Rows[r].Cells["id"].Value.ToString();
                txt_left.Text = dgv_rules.Rows[r].Cells["ruleS"].Value.ToString();
                txt_right.Text = dgv_rules.Rows[r].Cells["id_Majors"].Value.ToString();
                txt_des.Text = dgv_rules.Rows[r].Cells["description"].Value.ToString();

                btn_insert.Enabled = false;
            }
        }
    }
}

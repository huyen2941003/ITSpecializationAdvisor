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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_HCG.Views.Admin
{
    public partial class Rules : UserControl
    {
        private string selecteMajors;
        private string selectePreferences;
        private string selecteIdPreferences;

        public Rules()
        {
            InitializeComponent();
            txt_id.Enabled = false;
            btn_reset.PerformClick();
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            dgv_preference.DataSource = PreferenceDAO.Instance.getlistPreferences();
            dgv_preference.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_preference.ReadOnly = true;
            dgv_preference.Columns["id"].HeaderText = "Mã sở thích";
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
            string ruleSValue = dgv_rules.Rows[r].Cells["ruleS"].Value.ToString();
            int arrowIndex = ruleSValue.IndexOf('→');
            if (r >= 0)
            {
                txt_id.Text = dgv_rules.Rows[r].Cells["id"].Value.ToString();
                string leftCondition = ruleSValue.Substring(0, arrowIndex).Trim();
                txt_left.Text = leftCondition; 
                txt_right.Text = dgv_rules.Rows[r].Cells["id_Majors"].Value.ToString();
                txt_des.Text = dgv_rules.Rows[r].Cells["description"].Value.ToString();

                btn_insert.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
        }

        private void dgv_majors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                selecteMajors = dgv_majors.Rows[r].Cells["id"].Value.ToString();
            }
        }

        private void btn_insertMajors_Click(object sender, EventArgs e)
        {
            if (selecteMajors != null)
            {
                txt_right.Text = selecteMajors;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kết luận cho luật", "Thông báo");
            }
        }

        private void dgv_preference_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                selecteIdPreferences = dgv_preference.Rows[r].Cells["id"].Value.ToString();
                selectePreferences = dgv_preference.Rows[r].Cells["description"].Value.ToString();
            }
        }

        private void btn_insertPre_Click(object sender, EventArgs e)
        {
            if (selectePreferences != null)
            {
                grp_yesno.Text = selectePreferences + "?";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kết luận cho luật", "Thông báo");
            }
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            if(grp_yesno.Text != "")
            {
                if(txt_left.Text == "")
                {
                    txt_left.Text = selecteIdPreferences;
                }
                else
                {
                    txt_left.Text = txt_left.Text + " ∧ " + selecteIdPreferences;
                }
            }
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            if (grp_yesno.Text != "")
            {
                if (txt_left.Text == "")
                {
                    txt_left.Text = "¬" + selecteIdPreferences;
                }
                else
                {
                    txt_left.Text = txt_left.Text + " ∧ " + "¬" + selecteIdPreferences;
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_des.Text = "";
            grp_yesno.Text = "";
            txt_left.Text = "";
            txt_right.Text = "";

            btn_insert.Enabled = true;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            dgv_preference.DataSource = PreferenceDAO.Instance.getlistPreferences();
            dgv_majors.DataSource = MajorsDAO.Instance.getlistMajors();
            dgv_rules.DataSource = RulesDAO.Instance.getlistRules();
        }
        bool InsertRules(string ruleS, string id_Majors, string description)
        {
            return RulesDAO.Instance.InsertRules(ruleS, id_Majors, description);
        }
        
        private void btn_insert_Click(object sender, EventArgs e)
        {
            string left = txt_left.Text;
            string right = txt_right.Text;
            string description = txt_des.Text;
            if(string.IsNullOrEmpty(left) || string.IsNullOrEmpty(right) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!");
            }
            else
            {
                if (InsertRules(left, right, description))
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
        bool DeleteRule_Preferences(string id)
        {
            return RulesDAO.Instance.DeleteRule_Preferences(id);
        }
        bool DeleteRules(string id)
        {
            return RulesDAO.Instance.DeleteRules(id);
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            if (DeleteRule_Preferences(id))
            {
                if (DeleteRules(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    btn_reset.PerformClick();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại, vui lòng kiểm tra lại dữ liệu!");
                }
            }
            else
            {
                if (DeleteRules(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    btn_reset.PerformClick();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại, vui lòng kiểm tra lại dữ liệu!");
                }
            }
        }
        bool UpdateRules(string id, string ruleS, string id_Majors, string description)
        {
            return RulesDAO.Instance.UpdateRules(id, ruleS, id_Majors, description);
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string ruleS = txt_left.Text + " → " + txt_right.Text;
            string id_Majors = txt_right.Text;
            string description = txt_des.Text;
            if (UpdateRules(id, ruleS, id_Majors, description))
            {
                MessageBox.Show("Sửa thành công!");
                btn_reset.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại, vui lòng kiểm tra lại dữ liệu!");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            string currentText = txt_left.Text.Trim();
            if (!string.IsNullOrEmpty(currentText))
            {
                string[] parts = currentText.Split(new string[] { " ∧ " }, StringSplitOptions.None);
                if (parts.Length > 1)
                {
                    currentText = string.Join(" ∧ ", parts, 0, parts.Length - 1);
                }
                else
                {
                    currentText = "";
                }
                txt_left.Text = currentText;
            }
        }
    }
}

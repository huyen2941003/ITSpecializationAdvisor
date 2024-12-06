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
    public partial class Advisor2 : UserControl
    {
        private string selectePreferences;
        private string selecteIdPreferences;

        public Advisor2()
        {
            InitializeComponent();
            txt_preferences.ScrollBars = ScrollBars.Vertical;
            txt_explain.ScrollBars = ScrollBars.Vertical;
        }
        private void Advisor2_Load(object sender, EventArgs e)
        {
            dgv_preference.DataSource = PreferenceDAO.Instance.getlistPreferences2();
            dgv_preference.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_preference.ReadOnly = true;
            dgv_preference.Columns["id"].HeaderText = "Mã sở thích";
            dgv_preference.Columns["description"].HeaderText = "Mô tả";
            dgv_preference.Columns["id_majors"].HeaderText = "Chuyên ngành đi kèm";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchdtb = txt_search.Text.Trim();
            dgv_preference.DataSource = PreferenceDAO.Instance.Search(searchdtb);
        }

        private void btn_huy_Click_1(object sender, EventArgs e)
        {
            string[] lines = txt_preferences.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            if (lines.Length >= 1)
            {
                txt_preferences.Text = string.Join(Environment.NewLine, lines.Take(lines.Length - 1));
            }
        }

        private void btn_huytat_Click_1(object sender, EventArgs e)
        {
            txt_preferences.Text = "";
            txt_explain.Text = "";
            txt_majors.Text = "";
        }

        private void btn_yes_Click_1(object sender, EventArgs e)
        {
            if (grp_yesno.Text != "")
            {
                if (txt_preferences.Text == "")
                {
                    txt_preferences.Text = selecteIdPreferences + ": " + selectePreferences;
                }
                else
                {
                    txt_preferences.Text = txt_preferences.Text + Environment.NewLine + selecteIdPreferences + ": " + selectePreferences;
                }
            }
        }

        private void btn_no_Click_1(object sender, EventArgs e)
        {
            string currentText = grp_yesno.Text;
            int index = currentText.IndexOf("Sinh viên");
            if (index != -1 && !currentText.Contains("không"))
            {
                currentText = currentText.Insert(index + "Sinh viên".Length, " không");
                if (txt_preferences.Text == "" && grp_yesno.Text != "")
                {
                    txt_preferences.Text = "¬" + selecteIdPreferences + ": " + currentText;
                }
                else
                {
                    txt_preferences.Text = txt_preferences.Text + Environment.NewLine + "¬" + selecteIdPreferences + ": " + currentText;
                }
            }
        }

        private void dgv_preference_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                selecteIdPreferences = dgv_preference.Rows[r].Cells["id"].Value.ToString();
                selectePreferences = dgv_preference.Rows[r].Cells["description"].Value.ToString();
                if (selectePreferences != null)
                {
                    grp_yesno.Text = selectePreferences + "?";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn kết luận cho luật", "Thông báo");
                }
                txt_explain.Text = "";
                txt_majors.Text = "";
            }
        }
        private void btn_advisor_Click_1(object sender, EventArgs e)
        {
            string input = txt_preferences.Text;
            string[] parts = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            List<string> preferenceIds = new List<string>();
            
            // Trích xuất ID preference (S hoặc ¬S)
            foreach (string part in parts)
            {
                int colonIndex = part.IndexOf(':');
                if (colonIndex >= 0)
                {
                    string id = part.Substring(0, colonIndex).Trim();
                    if (id.StartsWith("S") || id.StartsWith("¬S"))
                    {
                        preferenceIds.Add(id);
                        MessageBox.Show(id, "Preference ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            Dictionary<string, int> majorCounts = RulesDAO.Instance.GetMajorCounts(preferenceIds);
            if (majorCounts.Count > 0)
            {
                var mostPopularMajor = majorCounts.OrderByDescending(x => x.Value).First();
                txt_majors.Text = $"{mostPopularMajor.Key}";
                int totalPreferences = majorCounts.Values.Sum();
                txt_explain.Text = $"Bởi vì có: {mostPopularMajor.Value}/{totalPreferences} sở thích phù hợp với chuyên ngành {mostPopularMajor.Key}.";
            }
            else
            {
                txt_majors.Text = "Không tìm thấy chuyên ngành nào cho các sở thích đã cho.";
                txt_explain.Text = string.Empty;
            }
        }
    }
}

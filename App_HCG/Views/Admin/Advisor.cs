using App_HCG.DAO;
using App_HCG.DTO;
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
    public partial class Advisor : UserControl
    {
        private string selectePreferences;
        private string selecteIdPreferences;

        public Advisor()
        {
            InitializeComponent();
            txt_preferences.ScrollBars = ScrollBars.Vertical; 
            txt_explain.ScrollBars = ScrollBars.Vertical;
        }

        private void Advisor_Load(object sender, EventArgs e)
        {
            dgv_preference.DataSource = PreferenceDAO.Instance.getlistPreferences();
            dgv_preference.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_preference.ReadOnly = true;
            dgv_preference.Columns["id"].HeaderText = "Mã sở thích";
            dgv_preference.Columns["description"].HeaderText = "Mô tả";
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            string[] lines = txt_preferences.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            if (lines.Length >= 1)
            {
                txt_preferences.Text = string.Join(Environment.NewLine, lines.Take(lines.Length - 1));
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
        private void btn_huytat_Click(object sender, EventArgs e)
        {
            txt_preferences.Text = "";
        }

        private void btn_select_Click(object sender, EventArgs e)
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

        private void btn_no_Click(object sender, EventArgs e)
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchdtb = txt_search.Text.Trim();
            dgv_preference.DataSource = PreferenceDAO.Instance.Search(searchdtb);
        }

        private void btn_advisor_Click(object sender, EventArgs e)
        {
            string input = txt_preferences.Text;
            string[] parts = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            List<string> results = new List<string>();
            foreach (string part in parts)
            {
                int colonIndex = part.IndexOf(':');
                if (colonIndex >= 0)
                {
                    string id = part.Substring(0, colonIndex).Trim();
                    if (id.StartsWith("S") || id.StartsWith("¬S"))
                    {
                        results.Add(id);
                    }
                }
            }
        }
    }
}

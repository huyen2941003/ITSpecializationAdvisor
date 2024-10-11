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

namespace App_HCG.Views.SignIn_Up
{
    public partial class frm_Signup : Form
    {
        public frm_Signup()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            frm_Signup frm = new frm_Signup();
            this.Hide();
            frm.ShowDialog();
        }
        bool InsertAccount(string name, string username, string password)
        {
            return AccountDAO.Instance.InsertAccount(name, username, password);
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string username = txt_username.Text;
            string password = txt_password.Text;
            string retype = txt_retype.Text;
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text) ||
                string.IsNullOrEmpty(txt_retype.Text) || retype != password)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và kiểm tra lại thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (AccountDAO.Instance.SetInsert(username).Count > 0)
                {
                    MessageBox.Show("Tài khoản của bạn đã tồn tại, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (InsertAccount(name, username, password))
                    {
                        MessageBox.Show("Tạo tài khoản thành công!");
                        Views.SignIn_Up.frm_Signin frm = new Views.SignIn_Up.frm_Signin();
                        this.Hide();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn đã tồn tại, vui lòng nhập lại!");
                    }
                }
            }
        }
        private void frm_Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void grp_dangnhap_Enter(object sender, EventArgs e)
        {

        }
    }
}

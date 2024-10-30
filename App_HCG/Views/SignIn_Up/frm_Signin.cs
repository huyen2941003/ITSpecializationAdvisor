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
    public partial class frm_Signin : Form
    {
        public frm_Signin()
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
            string username = txt_user.Text;
            string password = txt_password.Text;
            List<Account> accounts = AccountDAO.Instance.Login(username, password);
            if (string.IsNullOrEmpty(txt_user.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản và mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (AccountDAO.Instance.Login(username, password).Count > 0)
                {
                    Account loggedInUser = accounts[0];
                    //Views.Admin.Main frm = new Views.Admin.Main();
                    Views.Admin.Main frm = new Views.Admin.Main(loggedInUser.Role);
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại tên tài khoản hoặc mật khẩu");
                }
            }
        }
        private void frm_Signin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            frm_Signup frm = new frm_Signup();
            this.Hide();
            frm.ShowDialog();
        }
    }
}

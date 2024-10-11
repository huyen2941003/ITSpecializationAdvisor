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
    public partial class Main : Form
    {
        private int role;
        public int Role { get => role; set => role = value; }

        public Main(int role)
        {
            InitializeComponent();
            this.Role = role;
            DisplayAccount(role);
        }
        private void DisplayAccount(int role)
        {
            if (role == 1)
            {
                tưVấnToolStripMenuItem.Visible = true;
                tậpLuậtToolStripMenuItem.Visible = false;
                sựKiệnToolStripMenuItem.Visible = false;
                kếtQuảToolStripMenuItem.Visible = false;
                chuyênNgànhToolStripMenuItem.Visible = true;
                giớiThiệuToolStripMenuItem.Visible = true;
            }
            else if (role == 0)
            {
                tưVấnToolStripMenuItem.Visible = true;
                tậpLuậtToolStripMenuItem.Visible = true;
                sựKiệnToolStripMenuItem.Visible = true;
                kếtQuảToolStripMenuItem.Visible = true;
                chuyênNgànhToolStripMenuItem.Visible = true;
                giớiThiệuToolStripMenuItem.Visible = true;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.WindowState = FormWindowState.Maximized;
        }
        private void tưVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Admin.UserSelection myControl = new Views.Admin.UserSelection();
            panel_main.Controls.Clear();
            panel_main.Controls.Add(myControl);
        }

        private void tậpLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Admin.Preference myControl = new Views.Admin.Preference();
            panel_main.Controls.Clear();
            panel_main.Controls.Add(myControl);
        }

        private void sựKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Admin.Preference myControl = new Views.Admin.Preference();
            panel_main.Controls.Clear();
            panel_main.Controls.Add(myControl);
        }

        private void kếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Admin.Result myControl = new Views.Admin.Result();
            panel_main.Controls.Clear();
            panel_main.Controls.Add(myControl);
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Admin.Description myControl = new Views.Admin.Description();
            panel_main.Controls.Clear();
            panel_main.Controls.Add(myControl);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Views.Admin.About myControl = new Views.Admin.About();
            panel_main.Controls.Clear();
            panel_main.Controls.Add(myControl);
        }

        private void chuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Admin.About myControl = new Views.Admin.About();
            panel_main.Controls.Clear();
            panel_main.Controls.Add(myControl);
        }
    }
}

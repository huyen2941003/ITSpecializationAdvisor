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
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            List<DTO.Majors> listCNPM = DAO.MajorsDAO.Instance.getlistCNPM();
            string cnpm = string.Join("\n", listCNPM.Select(m => m.Description));
            label_cnpm.Text = cnpm;
            List<DTO.Majors> listHTTMDT = DAO.MajorsDAO.Instance.getlistHTTMDT();
            string httmdt = string.Join("\n", listCNPM.Select(m => m.Description));
            label_tmdt.Text = httmdt;
            List<DTO.Majors> listQTANM = DAO.MajorsDAO.Instance.getlistQTANM();
            string qtanm = string.Join("\n", listCNPM.Select(m => m.Description));
            label_qtanm.Text = qtanm;
        }

    }
}

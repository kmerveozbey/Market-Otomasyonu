using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Market.BLL.Repository;
using DevExpress.Pdf;
using DevExpress.XtraReports.UI;

namespace Market.UI
{
    public partial class RaporForm : DevExpress.XtraEditors.XtraForm
    {
        public RaporForm()
        {
            InitializeComponent();
        }
        


        private void btnSiparişRaporu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = new SiparisRepo().SiparisRaporu();
     
        }
        private void btnCiktiAl_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SiparisRapor report = new SiparisRapor();
            report.DataSource = new SiparisRepo().SiparisRaporu();

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                printTool.PrintDialog();
            }

        }

            private void btnGunlukSiparisRaporu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = new SatisRepo().GunlukSatisRaporu();
        }
        private void btnGunlukSatisCikti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SatisRapor report = new SatisRapor();
            report.DataSource = new SatisRepo().SatisRaporu();

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                printTool.PrintDialog();
            }
        }

        private void btnAylıkSiparisRaporu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = new SatisRepo().SatisRaporu();
        }

        private void btnAylikSatisCikti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = new SatisRepo().SatisRaporu();
        }
    }
}
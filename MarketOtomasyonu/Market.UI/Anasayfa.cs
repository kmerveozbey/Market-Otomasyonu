using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Market.UI.Formlar;

namespace Market.UI
{
    public partial class Anasayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        KategoriForm frmKategori;
        UrunForm frmUrun;
        CalisanForm frmCalisan;
        TedarikciForm frmTedarikci;
        SiparisForm frmSiparis;
        SatisForm frmSatis;
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Hide();
                frmKategori = new KategoriForm();
                frmKategori.MdiParent = this;
                frmKategori.Text = "Kategori İşlemleri";
                frmKategori.WindowState = FormWindowState.Maximized;
                frmKategori.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Hide();
                frmUrun = new UrunForm();
                frmUrun.MdiParent = this;
                frmUrun.Text = "Ürün İşlemleri";
                frmUrun.WindowState = FormWindowState.Maximized;
                frmUrun.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Hide();
                frmCalisan = new CalisanForm();
                frmCalisan.MdiParent = this;
                frmCalisan.Text = "Çalışan İşlemleri";
                frmCalisan.WindowState = FormWindowState.Maximized;
                frmCalisan.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Hide();
                frmTedarikci = new TedarikciForm();
                frmTedarikci.MdiParent = this;
                frmTedarikci.Text = "Tedarikçi İşlemleri";
                frmTedarikci.WindowState = FormWindowState.Maximized;
                frmTedarikci.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Hide();
            frmSiparis = new SiparisForm();
            frmSiparis.MdiParent = this;
            frmSiparis.Text = "Sipariş İşlemleri";
            frmSiparis.WindowState = FormWindowState.Maximized;
            frmSiparis.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Hide();
            frmSatis = new SatisForm();
            frmSatis.MdiParent = this;
            frmSatis.Text = "Satış İşlemleri";
            frmSatis.WindowState = FormWindowState.Maximized;
            frmSatis.Show();
        }
        RaporForm frmRapor;
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Hide();
            frmRapor = new RaporForm();
            frmRapor.MdiParent = this;
            frmRapor.Text = "Rapor İşlemleri";
            frmRapor.WindowState = FormWindowState.Maximized;
            frmRapor.Show();

        }
    }
}
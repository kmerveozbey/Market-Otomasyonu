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
using Market.Entity.Models;
using DevExpress.XtraEditors.Camera;

namespace Market.UI.Formlar
{
    public partial class UrunForm : DevExpress.XtraEditors.XtraForm
    {
        public UrunForm()
        {
            InitializeComponent();
        }
        Urun seciliUrun=null;

        private void VerileriGetir()
        {
            try
            {
                gridControl1.DataSource = new UrunRepo().GetAll();
                cmbKategori.Properties.DataSource = new KategoriRepo().GetAll();
                cmbKategori.Properties.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                new UrunRepo().Insert(new Urun()
                {
                    UrunAdi = txtUrunAdi.Text,
                    UrunBarkod = txtBarkod.Text,
                    Stok = Convert.ToInt16(txtStok.Text),
                    IndirimMiktari = Convert.ToDecimal(txtIndirimMiktari.Text) / 100,
                    KategoriID = Convert.ToInt32(cmbKategori.GetColumnValue("ID")),
                    SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text),
                    SatistaMi = cSatistaMi.Checked,
                    Marka = txtMarka.Text,
                    Fotograf = (peResim.EditValue as byte[])
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            VerileriGetir();
        }

        private void btnGuncelle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var urunID = seciliUrun.ID;
            try
            {
                var urun = new UrunRepo().GetById(urunID);
                urun.UrunAdi = txtUrunAdi.Text;
                urun.UrunBarkod = txtBarkod.Text;
                urun.Stok = Convert.ToInt16(txtStok.Text);
                urun.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
                urun.KategoriID = Convert.ToInt32(cmbKategori.GetColumnValue("ID"));
                urun.SatistaMi = cSatistaMi.Checked;
                urun.IndirimMiktari = Convert.ToDecimal(txtIndirimMiktari.Text);
                urun.Fotograf = (peResim.EditValue as byte[]);
                urun.Marka = txtMarka.Text;
                DialogResult cevap = MessageBox.Show($"{seciliUrun.UrunAdi} isimli ürünü güncellemek istiyor musunuz?", "Ürün Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (cevap == DialogResult.Yes)
                    new UrunRepo().Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            VerileriGetir();
        }

        private void gvUrun_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gvUrun.GetSelectedRows().Length == 0) return;
            seciliUrun = gvUrun.GetFocusedRow() as Urun;
            txtUrunAdi.Text = seciliUrun.UrunAdi;
            txtBarkod.Text = seciliUrun.UrunBarkod;
            txtStok.Text = seciliUrun.Stok.ToString();
            peResim.EditValue = seciliUrun.Fotograf;
            txtSatisFiyati.Text = seciliUrun.AlisFiyati.ToString();//satış fiyatını güncellemeyi unutma
            cSatistaMi.Checked = (bool)seciliUrun.SatistaMi;
            txtMarka.Text = seciliUrun.Marka;
            txtIndirimMiktari.Text = seciliUrun.IndirimMiktari.ToString();
            cmbKategori.Text = new KategoriRepo().GetById(seciliUrun.KategoriID).ToString();

        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = dosyaAc.ShowDialog();
            if (cevap == DialogResult.OK)
                peResim.Image = Image.FromFile(dosyaAc.FileName);
        }

        private void btnKamera_Click(object sender, EventArgs e)
        {
            ResimCek();
        }

        public void ResimCek()
        {
            var dialog = new TakePictureDialog();
            var cevap = dialog.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                peResim.Image = dialog.Image;
            }
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            VerileriGetir();
            txtBarkod.Focus();
        }
    }
}
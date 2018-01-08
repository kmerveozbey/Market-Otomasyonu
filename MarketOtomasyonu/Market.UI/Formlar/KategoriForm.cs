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

namespace Market.UI.Formlar
{
    public partial class KategoriForm : DevExpress.XtraEditors.XtraForm
    {
        public KategoriForm()
        {
            InitializeComponent();
        }
        private void KategoriForm_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        Kategori seciliKategori = null;

        private void VerileriGetir()
        {
            try
            {
                gcKategori.DataSource = new KategoriRepo().GetAll();
                gvKategori.Columns["ID"].Visible = false;

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
                new KategoriRepo().Insert(new Kategori()
                {
                    KategoriAdi = txtKategoriAdi.Text,
                    Aciklama = txtAciklama.Text,
                    Kdv = Convert.ToDecimal(txtKDV.Text) / 100
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            VerileriGetir();
        }

        private void btnSil_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (seciliKategori == null)
                {
                    MessageBox.Show("Silinecek kategori bulunamadı");
                    VerileriGetir();
                    return;
                }
                DialogResult cevap = MessageBox.Show($"{seciliKategori.KategoriAdi} isimli kategoriyi silmek istiyor musunuz?", "Kategori Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (cevap == DialogResult.Yes)
                    new KategoriRepo().Delete(seciliKategori);
                VerileriGetir();
                MessageBox.Show($"{seciliKategori.KategoriAdi} adlı kategori silinmiştir");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            VerileriGetir();
        }

        private void btnGuncelle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var kategoriID = seciliKategori.ID;
            try
            {
                var kategori = new KategoriRepo().GetById(kategoriID);
                kategori.KategoriAdi = txtKategoriAdi.Text;
                kategori.Aciklama = txtAciklama.Text;
                kategori.Kdv = Convert.ToDecimal(txtKDV.Text) / 100;
                DialogResult cevap = MessageBox.Show($"{seciliKategori.KategoriAdi} isimli kategoriyi güncellemek istiyor musunuz?", "Kategori Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (cevap == DialogResult.Yes)
                    new KategoriRepo().Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            VerileriGetir();
        }

        private void gvKategori_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gvKategori.GetSelectedRows().Length == 0) return;
            seciliKategori = gvKategori.GetFocusedRow() as Kategori;
            txtKategoriAdi.Text = seciliKategori.KategoriAdi;
            txtAciklama.Text = seciliKategori.Aciklama;
            txtKDV.Text = seciliKategori.Kdv.ToString();
        }
    }
}
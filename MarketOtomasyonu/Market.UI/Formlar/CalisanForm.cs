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
    public partial class CalisanForm : DevExpress.XtraEditors.XtraForm
    {
        public CalisanForm()
        {
            InitializeComponent();
        }
        Calisan seciliCalisan = null;

        void VerileriGetir()
        {
            try
            {
                gridControl1.DataSource = new CalisanRepo().GetAll();
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
                new CalisanRepo().Insert(new Calisan()
                {
                    CalisanAdi = txtAd.Text,
                    CalisanSoyadi = txtSoyad.Text,
                    TelefonNumarasi = txtTelNo.Text,
                    Eposta = txtEmail.Text,
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
                if (seciliCalisan == null)
                {
                    MessageBox.Show("Silinecek çalışan bulunamadı");
                    VerileriGetir();
                    return;
                }
                new CalisanRepo().Delete(seciliCalisan);
                VerileriGetir();
                MessageBox.Show($"{seciliCalisan.CalisanAdi} adlı çalışan silinmiştir");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            VerileriGetir();
        }
        private void btnGuncelle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var calisanID = seciliCalisan.ID;
            try
            {
                var calisan = new CalisanRepo().GetById(calisanID);
                calisan.CalisanAdi = txtAd.Text;
                calisan.CalisanSoyadi = txtSoyad.Text;
                calisan.TelefonNumarasi = txtTelNo.Text;
                calisan.Eposta = txtEmail.Text;
                DialogResult cevap = MessageBox.Show($"{seciliCalisan.CalisanAdi} isimli çalışanı güncellemek istiyor musunuz?", "Çalışan Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (cevap == DialogResult.Yes)
                    new CalisanRepo().Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            VerileriGetir();
        }

        private void gvCalisan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gvCalisan.GetSelectedRows().Length == 0) return;
            seciliCalisan = gvCalisan.GetFocusedRow() as Calisan;
            txtAd.Text = seciliCalisan.CalisanAdi;
            txtSoyad.Text = seciliCalisan.CalisanSoyadi;
            txtTelNo.Text = seciliCalisan.TelefonNumarasi;
            txtEmail.Text = seciliCalisan.Eposta;
        }

        private void CalisanForm_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }
    }
}
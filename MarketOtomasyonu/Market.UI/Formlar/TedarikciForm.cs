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
    public partial class TedarikciForm : DevExpress.XtraEditors.XtraForm
    {
        public TedarikciForm()
        {
            InitializeComponent();
        }
        Tedarikci seciliTedarikci = null;
        void VerileriGetir()
        {
            try
            {
                gridControl1.DataSource = new TedarikciRepo().GetAll();
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
                new TedarikciRepo().Insert(new Tedarikci()
                {
                    TedarikciAdi = txtTAdi.Text,
                    SirketAdi = txtSAdi.Text,
                    TelefonNo = txtTelNo.Text,
                    Adresi = txtAdres.Text,
                    Email = txtEmail.Text,
                    Il = txtIl.Text,
                    Ilce = txtIlce.Text,
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
            var tedarikciID = seciliTedarikci.ID;
            try
            {
                var tedarikci = new TedarikciRepo().GetById(tedarikciID);
                tedarikci.TedarikciAdi = txtTAdi.Text;
                tedarikci.SirketAdi = txtSAdi.Text;
                tedarikci.Adresi = txtAdres.Text;
                tedarikci.TelefonNo = txtTelNo.Text;
                tedarikci.Email = txtEmail.Text;
                tedarikci.Il = txtIl.Text;
                tedarikci.Ilce = txtIlce.Text;
                DialogResult cevap = MessageBox.Show($"{seciliTedarikci.TedarikciAdi} isimli tedarikçiyi güncellemek istiyor musunuz?", "Tedarikçi Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (cevap == DialogResult.Yes)
                    new TedarikciRepo().Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            VerileriGetir();
        }
    }
}
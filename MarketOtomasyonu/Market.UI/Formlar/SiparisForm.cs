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
using Market.Entity;
using Market.BLL.Repository;
using Market.Entity.Models;

namespace Market.UI.Formlar
{
    public partial class SiparisForm : DevExpress.XtraEditors.XtraForm
    {
        public SiparisForm()
        {
            InitializeComponent();
        }
        List<SiparisViewModel> SiparisListesi = new List<SiparisViewModel>();
        decimal toplamTutar = 0;
        Urun urunum;
        private void btnEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int miktar = Convert.ToInt32(txtAdet.Value);
            bool varmi = false;
            int urunID = Convert.ToInt32(cmbUrun.GetColumnValue("ID"));
            var seciliurun = new UrunRepo().GetById(urunID);
            urunum = UrunRepo.BarkodaGoreGetir(seciliurun.UrunBarkod);

            int tedarikciID = Convert.ToInt32(cmbTedarikci.GetColumnValue("ID"));
            Tedarikci seciliTedarikci = new TedarikciRepo().GetById(tedarikciID);
            try
            {
                foreach (var item in SiparisListesi)
                {
                    if (item.UrunAdi == seciliurun.UrunAdi)
                    {
                        item.Adet += miktar;
                        varmi = true;
                    }
                }
                if (!varmi)
                {
                    SiparisViewModel yeni = new SiparisViewModel();
                    yeni.Adet = miktar;
                    yeni.UrunID = cmbUrun.GetColumnValue("ID").ToString();
                    yeni.UrunAdi = seciliurun.UrunAdi;
                    yeni.Barkod = seciliurun.UrunBarkod;
                    yeni.Fiyat = seciliurun.SatisFiyati;
                    yeni.TedarikciAdi = seciliTedarikci.TedarikciAdi;
                    yeni.TedarikciID = seciliTedarikci.ID;
                    SiparisListesi.Add(yeni);
                }
                foreach (var item in SiparisListesi)
                {
                    toplamTutar += item.ToplamFiyat;
                }
                txtToplamTutar.Text = toplamTutar.ToString();
                SepetYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }

        void VerileriGetir()
        {
            try
            {
                cmbTedarikci.Properties.DataSource = new TedarikciRepo().GetAll();
                cmbTedarikci.Properties.ValueMember = "ID";
                cmbUrun.Properties.DataSource = new UrunRepo().GetAll();
                cmbUrun.Properties.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SepetYenile()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = SiparisListesi;
            gvSiparis.Columns["UrunID"].Visible = false;
            gvSiparis.Columns["TedarikciID"].Visible = false;
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTedarikci.Properties.DataSource = new TedarikciRepo().GetAll();
                cmbTedarikci.Properties.ValueMember = "ID";
                cmbUrun.Properties.DataSource = new UrunRepo().GetAll();
                cmbUrun.Properties.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUrunuCikar_Click(object sender, EventArgs e)
        {
            if (gvSiparis.GetSelectedRows().Length == 0) return;
            SiparisListesi.Remove(gvSiparis.GetFocusedRow() as SiparisViewModel);
            VerileriGetir();
            SepetYenile();

        }

        private void SiparisiTamamla_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                SiparisRepo siparisRepo = new SiparisRepo();
                Siparis siparis = new Siparis()
                {
                    ToplamFiyat = Convert.ToDecimal(txtToplamTutar.Text),
                    TeslimTarihi = DateTime.Now.AddDays(7),
                    IndirimMiktari = Convert.ToDecimal(txtIndirimMiktari.Text),
                };
                List<SiparisDetay> siparisDetaylari = new List<SiparisDetay>();
                foreach (var item in SiparisListesi)
                {
                    siparisDetaylari.Add(new SiparisDetay()
                    {
                        Adet = Convert.ToInt16(txtAdet.Value),
                        TedarikciID = Convert.ToInt32(item.TedarikciID),
                        UrunID = Convert.ToInt32(item.UrunID),
                        UrunFiyati = Convert.ToDecimal(item.Fiyat),
                    });
                    var durum = new SiparisRepo().SiparisOlustur(siparis, siparisDetaylari);
                    if (durum)
                    {
                        MessageBox.Show("Siparişiniz Oluşmuştur.");
                    }
                    else
                    {
                        MessageBox.Show("Siparişiz oluşturulurken bir hata meydana geldi");
                    }
                    foreach (SiparisDetay urunstok in siparisDetaylari)
                    {
                        urunum.Stok += Convert.ToInt16(urunstok.Adet);
                        new UrunRepo().Update();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            VerileriGetir();
        }
    }
}
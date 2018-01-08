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
using Market.Entity.Models;
using Market.BLL.Repository;
using Market.Entity;
using static Market.Entity.Enums.Enum;

namespace Market.UI.Formlar
{
    public partial class SatisForm : DevExpress.XtraEditors.XtraForm
    {
        public SatisForm()
        {
            InitializeComponent();
        }
        List<SatisViewModel> SepetListesi = new List<SatisViewModel>();
        string barkod;
        Urun seciliurun;
        UrunForm frmUrun;
        FisForm frmFis;
        private void txtUrunBarkod_KeyDown(object sender, KeyEventArgs e)
       {
            if (e.KeyCode == Keys.Enter)
            {
                int miktar = Convert.ToInt32(txtAdet.Value);
                barkod =txtUrunBarkod.Text;
                 seciliurun= UrunRepo.BarkodaGoreGetir(barkod);
                if (seciliurun == null)
                {
                    frmUrun = new UrunForm();
                    frmUrun.Show();
                    return;
                }
                bool varmi = false;
                try
                {
                    foreach (var item in SepetListesi)
                    {
                        if (item.Barkod == seciliurun.UrunBarkod)
                        {
                            item.Adet += miktar;
                            varmi = true;
                        }
                    }
                    if (!varmi)
                    {
                        SatisViewModel yeni = new SatisViewModel();
                        yeni.Fiyat = seciliurun.SatisFiyati;
                        yeni.KDVSizFiyat = seciliurun.AlisFiyati;
                        yeni.KDV = seciliurun.Kategori.Kdv;
                        yeni.Barkod = barkod;
                        yeni.UrunID = seciliurun.ID.ToString();
                        yeni.Adet = miktar;
                        yeni.UrunAdi = seciliurun.UrunAdi;
                        SepetListesi.Add(yeni);
                    }
                    SepetYenile();
                    decimal toplamTutar = 0;
                    foreach (var item in SepetListesi)
                    {
                        toplamTutar += item.ToplamFiyat;
                    }
                    txtToplamTutar.Text = toplamTutar.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {
            VerileriGetir();
            txtUrunBarkod.Focus();
            krediKarti.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            paraustu.Visibility= DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            verilenpara.Visibility= DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void VerileriGetir()
        {
            cmbKasiyer.Properties.DataSource = new CalisanRepo().GetAll();
            cmbKasiyer.Properties.ValueMember = "ID";
            cmbKrediKarti.Properties.Items.AddRange(Enum.GetNames(typeof(KartCesitleri)));
        }

        void SepetYenile()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = SepetListesi;
        }
        public static int fisNo;
        private void btnNakit_Click(object sender, EventArgs e)
        {
            paraustu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            verilenpara.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            try
            {
                SatisRepo satisRepo = new SatisRepo();
                Satis satis = new Satis()
                {
                    CalisanID = Convert.ToInt32(cmbKasiyer.GetColumnValue("ID")),
                    ToplamFiyat = Convert.ToDecimal(txtToplamTutar.Text),
                };
                List<SatisDetay> satisDetaylari = new List<SatisDetay>();
                foreach (var item in SepetListesi)
                {
                    satisDetaylari.Add(new SatisDetay()
                    {
                        Adet = Convert.ToInt32(txtAdet.Value),
                        SatisFiyati = Convert.ToDecimal(item.Fiyat),
                        UrunID = Convert.ToInt32(item.UrunID),
                        OdemeTipi = OdemeTipi.Nakit,

                    });
                    
                }
                var durum = new SatisRepo().SatisOlustur(satis, satisDetaylari);
                if (durum)
                {
                    fisNo = satis.ID;
                    MessageBox.Show("Siparişiniz Oluşmuştur.");
                }
                else
                {
                    MessageBox.Show("Siparişiz oluşturulurken bir hata meydana geldi");
                }
                foreach (SatisDetay item in satisDetaylari)
                {
                    seciliurun.Stok -= Convert.ToInt16(item.Adet);
                    new UrunRepo().Update();
                }
                frmFis = new FisForm();
                frmFis.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnKrediKarti_Click(object sender, EventArgs e)
        {
            krediKarti.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void cmbKrediKarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SatisRepo satisRepo = new SatisRepo();
                Satis satis = new Satis()
                {
                    CalisanID = Convert.ToInt32(cmbKasiyer.GetColumnValue("ID")),
                    ToplamFiyat = Convert.ToDecimal(txtToplamTutar.Text),
                };
                List<SatisDetay> satisDetaylari = new List<SatisDetay>();
                foreach (var item in SepetListesi)
                {
                    satisDetaylari.Add(new SatisDetay()
                    {
                        Adet = Convert.ToInt32(txtAdet.Value),
                        SatisFiyati = Convert.ToDecimal(item.Fiyat),
                        UrunID = Convert.ToInt32(item.UrunID),
                        OdemeTipi = OdemeTipi.KrediKartı,
                        KartCesitleri= (KartCesitleri)Enum.Parse(typeof(KartCesitleri), cmbKrediKarti.SelectedItem.ToString()),
                    });
                }
                var durum = new SatisRepo().SatisOlustur(satis, satisDetaylari);
                if (durum)
                {
                    fisNo = satis.ID;
                    MessageBox.Show("Siparişiniz Oluşmuştur.");
                }
                else
                {
                    MessageBox.Show("Siparişiz oluşturulurken bir hata meydana geldi");
                }
                frmFis = new FisForm();
                frmFis.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUrunuCikar_Click(object sender, EventArgs e)
        {
            if (gvSatis.GetSelectedRows().Length == 0) return;
            SepetListesi.Remove(gvSatis.GetFocusedRow() as SatisViewModel);
            VerileriGetir();
            SepetYenile();
        }
    }
    }
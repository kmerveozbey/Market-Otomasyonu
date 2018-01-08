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
using Market.UI.Formlar;
using Market.BLL.Repository;
using Market.Entity.Models;
using Market.Entity;

namespace Market.UI
{
    public partial class FisForm : DevExpress.XtraEditors.XtraForm
    {
        public FisForm()
        {
            InitializeComponent();
        }
        List<FisViewModel> SepetListesi = new List<FisViewModel>();

        void SepetYenile()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = SepetListesi;
        }
        private void FisForm_Load(object sender, EventArgs e)
        {
            tarihsaat.Text = DateTime.Now.ToString();
            fisNumarasi.Text = "Fiş No:" + SatisForm.fisNo;
            List<SatisDetay> satisDetayID = SatisDetayRepo.IDyeGoreGetir(SatisForm.fisNo);
            try
            {

                foreach (SatisDetay a in satisDetayID)
                {
                    FisViewModel yeni = new FisViewModel();
                    yeni.UrunAdi = a.Urun.UrunAdi;
                    yeni.Fiyat = Convert.ToDecimal(a.SatisFiyati);
                    yeni.KDV = a.Urun.Kategori.Kdv;
                    yeni.Adet = Convert.ToInt32(a.Adet);
                    SepetListesi.Add(yeni);
                }
                
                

                SepetYenile();
                decimal toplamTutar = 0;
                foreach (var item in SepetListesi)
                {
                    toplamTutar += item.ToplamFiyat;
                }
                txtToplamTutar.Text = toplamTutar.ToString();
                decimal toplamkdv = 0;
                decimal kdv = 0;
                foreach (var item in SepetListesi)
                {
                    kdv=item.Fiyat-item.Fiyat/(1+item.KDV);
                    toplamkdv +=kdv;
                }
                txtToplamKDV.Text = toplamkdv.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
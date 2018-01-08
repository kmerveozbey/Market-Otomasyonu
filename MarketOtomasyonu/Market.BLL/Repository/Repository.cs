using Market.DAL;
using Market.Entity;
using Market.Entity.Models;
using Market.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Repository
{
    public class KategoriRepo : RepositoryBase<Kategori, int> { }
    public class UrunRepo : RepositoryBase<Urun, int>
    {
        public static Urun BarkodaGoreGetir(string Barkod)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                return dbContext.Urunler.Where(x => x.UrunBarkod == Barkod).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
    public class SatisRepo : RepositoryBase<Satis, int>
    {
        public bool SatisOlustur(Satis yeniSatis, List<SatisDetay> sepetim)
        {
            if (dbContext == null) dbContext = new MyContext();
            using (var tran = dbContext.Database.BeginTransaction())
            {
                try
                {
                    Insert(yeniSatis);
                    foreach (var item in sepetim)
                    {
                        item.SatisID = yeniSatis.ID;
                    }
                    dbContext.SatisDetaylar.AddRange(sepetim);
                    
                    dbContext.SaveChanges();
                    tran.Commit();
                    return true;
                }
                catch (Exception)
                {
                    tran.Rollback();
                    return false;
                }
            }

        }

        public List<SatisRaporViewModel> SatisRaporu()
        {
            var db = new MyContext();
            var rapor = from urun in db.Urunler
                        join kategori in db.Kategoriler
                        on urun.KategoriID equals kategori.ID
                        join SatisDetay in db.SatisDetaylar
                        on urun.ID equals SatisDetay.UrunID
                        join Satis in db.Satislar
                        on SatisDetay.SatisID equals Satis.ID
                        select new
                        {
                            SatisID = Satis.ID,
                            kategori.KategoriAdi,
                            urun.UrunAdi,
                            Fiyat = SatisDetay.SatisFiyati,
                            Adet=SatisDetay.Adet,
                            Toplam = SatisDetay.SatisFiyati * SatisDetay.Adet,
                            Indirim = 1 - SatisDetay.Urun.IndirimMiktari,
                            Satis.OlusturmaTarihi,
                        };
            var raporson = rapor.AsEnumerable().Select(x => new SatisRaporViewModel
            {
                SatisID = x.SatisID,
                Adet = Convert.ToInt16(x.Adet),
                UrunAdi = x.UrunAdi,
                Fiyat = Convert.ToDecimal(x.Fiyat),
                KategoriAdi = x.KategoriAdi,
                Toplam = Convert.ToDecimal(x.Toplam) * Convert.ToDecimal(x.Indirim),
                SatisTarihi = x.OlusturmaTarihi

            });
            return raporson.ToList();
        }

        public List<SatisRaporViewModel> GunlukSatisRaporu()
        {
            var db = new MyContext();
            var rapor = from urun in db.Urunler
                        join kategori in db.Kategoriler
                        on urun.KategoriID equals kategori.ID
                        join SatisDetay in db.SatisDetaylar
                        on urun.ID equals SatisDetay.UrunID
                        join Satis in db.Satislar
                        on SatisDetay.SatisID equals Satis.ID
                        select new
                        {
                            SatisID = Satis.ID,
                            kategori.KategoriAdi,
                            urun.UrunAdi,
                            Fiyat = SatisDetay.SatisFiyati,
                            Adet = SatisDetay.Adet,
                            Toplam = SatisDetay.SatisFiyati * SatisDetay.Adet,
                            Indirim = 1 - SatisDetay.Urun.IndirimMiktari,
                            Satis.OlusturmaTarihi,
                        };
            var raporson = rapor.AsEnumerable().Select(x => new SatisRaporViewModel
            {
                SatisID = x.SatisID,
                Adet = Convert.ToInt16(x.Adet),
                UrunAdi = x.UrunAdi,
                Fiyat = Convert.ToDecimal(x.Fiyat),
                KategoriAdi = x.KategoriAdi,
                Toplam = Convert.ToDecimal(x.Toplam) * Convert.ToDecimal(x.Indirim),
                SatisTarihi = x.OlusturmaTarihi

            }).Where(x=>x.SatisTarihi.ToShortDateString()== DateTime.Now.ToShortDateString());
            return raporson.ToList();
        }
    }
    public class SatisDetayRepo : RepositoryBase<SatisDetay, int> {

        public static List<SatisDetay> IDyeGoreGetir(int ID)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                return dbContext.SatisDetaylar.Where(x => x.SatisID == ID).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public class TedarikciRepo : RepositoryBase<Tedarikci, int> { }
    public class CalisanRepo : RepositoryBase<Calisan, int> { }
    public class SiparisRepo : RepositoryBase<Siparis, int>
    {
        public bool SiparisOlustur(Siparis yeniSiparis, List<SiparisDetay> siparisSepetim)
        {
            if (dbContext == null) dbContext = new MyContext();
            using (var tran = dbContext.Database.BeginTransaction())
            {
                try
                {
                    Insert(yeniSiparis);
                    foreach (var item in siparisSepetim)
                    {
                        item.SiparisID = yeniSiparis.ID;
                    }
                    dbContext.SiparisDetaylar.AddRange(siparisSepetim);
                    dbContext.SaveChanges();
                    tran.Commit();
                    return true;
                }
                catch (Exception)
                {
                    tran.Rollback();
                    return false;
                }
            }

        }

        public List<SiparisRaporViewModel> SiparisRaporu()
        {
            var db = new MyContext();
            var rapor = from urun in db.Urunler
                        join kategori in db.Kategoriler
                        on urun.KategoriID equals kategori.ID
                        join siparisdetay in db.SiparisDetaylar
                        on urun.ID equals siparisdetay.UrunID
                        join siparis in db.Siparisler
                        on siparisdetay.SiparisID equals siparis.ID
                        select new
                        {
                            SiparisID = siparis.ID,
                            kategori.KategoriAdi,
                            urun.UrunAdi,
                            siparisdetay.Adet,
                            Fiyat = siparisdetay.UrunFiyati,
                            Toplam = siparisdetay.UrunFiyati * siparisdetay.Adet,
                            Indirim = 1 - siparisdetay.Urun.IndirimMiktari,
                            siparis.TeslimTarihi,
                        };
            var raporson = rapor.AsEnumerable().Select(x => new SiparisRaporViewModel
            {
                SiparisID = x.SiparisID,
                Adet = Convert.ToInt16(x.Adet),
                UrunAdi = x.UrunAdi,
                Fiyat = Convert.ToDecimal(x.Fiyat),
                KategoriAdi = x.KategoriAdi,
                Toplam = Convert.ToDecimal(x.Toplam) * Convert.ToDecimal(x.Indirim),
                TeslimAlınmaGunu=x.TeslimTarihi
                
            });
            return raporson.ToList();
        }
    }
    public class SiparisDetayRepo : RepositoryBase<SiparisDetay, int> { }
}

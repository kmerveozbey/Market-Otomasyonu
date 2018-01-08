namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calisanlar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CalisanAdi = c.String(nullable: false, maxLength: 40),
                        CalisanSoyadi = c.String(nullable: false, maxLength: 40),
                        TelefonNumarasi = c.String(nullable: false, maxLength: 25),
                        Eposta = c.String(maxLength: 45),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Satislar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CalisanID = c.Int(nullable: false),
                        ToplamFiyat = c.Decimal(precision: 18, scale: 2),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Calisanlar", t => t.CalisanID, cascadeDelete: true)
                .Index(t => t.CalisanID);
            
            CreateTable(
                "dbo.SatisDetaylar",
                c => new
                    {
                        SatisID = c.Int(nullable: false),
                        UrunID = c.Int(nullable: false),
                        Adet = c.Int(),
                        SatisFiyati = c.Decimal(precision: 18, scale: 2),
                        OdemeTipi = c.Byte(),
                        KartCesitleri = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => new { t.SatisID, t.UrunID })
                .ForeignKey("dbo.Satislar", t => t.SatisID, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunID, cascadeDelete: true)
                .Index(t => t.SatisID)
                .Index(t => t.UrunID);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KategoriID = c.Int(nullable: false),
                        UrunBarkod = c.String(nullable: false, maxLength: 40),
                        UrunAdi = c.String(nullable: false, maxLength: 40),
                        Marka = c.String(nullable: false, maxLength: 40),
                        Stok = c.Short(),
                        AlisFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IndirimMiktari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fotograf = c.Binary(),
                        SatistaMi = c.Boolean(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriID, cascadeDelete: true)
                .Index(t => t.KategoriID)
                .Index(t => t.UrunBarkod, unique: true);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 30),
                        Aciklama = c.String(),
                        Kdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SiparisDetaylar",
                c => new
                    {
                        SiparisID = c.Int(nullable: false),
                        TedarikciID = c.Int(nullable: false),
                        UrunID = c.Int(nullable: false),
                        UrunFiyati = c.Decimal(precision: 18, scale: 2),
                        Adet = c.Int(),
                    })
                .PrimaryKey(t => new { t.SiparisID, t.TedarikciID, t.UrunID })
                .ForeignKey("dbo.Siparisler", t => t.SiparisID, cascadeDelete: true)
                .ForeignKey("dbo.Tedarikciler", t => t.TedarikciID, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunID, cascadeDelete: true)
                .Index(t => t.SiparisID)
                .Index(t => t.TedarikciID)
                .Index(t => t.UrunID);
            
            CreateTable(
                "dbo.Siparisler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ToplamFiyat = c.Decimal(precision: 18, scale: 2),
                        TeslimTarihi = c.DateTime(nullable: false),
                        IndirimMiktari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tedarikciler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TedarikciAdi = c.String(nullable: false, maxLength: 40),
                        SirketAdi = c.String(nullable: false, maxLength: 40),
                        Adresi = c.String(nullable: false, maxLength: 40),
                        Il = c.String(nullable: false, maxLength: 15),
                        Ilce = c.String(nullable: false, maxLength: 15),
                        TelefonNo = c.String(nullable: false, maxLength: 25),
                        Email = c.String(maxLength: 45),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisDetaylar", "UrunID", "dbo.Urunler");
            DropForeignKey("dbo.SiparisDetaylar", "TedarikciID", "dbo.Tedarikciler");
            DropForeignKey("dbo.SiparisDetaylar", "SiparisID", "dbo.Siparisler");
            DropForeignKey("dbo.SatisDetaylar", "UrunID", "dbo.Urunler");
            DropForeignKey("dbo.Urunler", "KategoriID", "dbo.Kategoriler");
            DropForeignKey("dbo.SatisDetaylar", "SatisID", "dbo.Satislar");
            DropForeignKey("dbo.Satislar", "CalisanID", "dbo.Calisanlar");
            DropIndex("dbo.SiparisDetaylar", new[] { "UrunID" });
            DropIndex("dbo.SiparisDetaylar", new[] { "TedarikciID" });
            DropIndex("dbo.SiparisDetaylar", new[] { "SiparisID" });
            DropIndex("dbo.Urunler", new[] { "UrunBarkod" });
            DropIndex("dbo.Urunler", new[] { "KategoriID" });
            DropIndex("dbo.SatisDetaylar", new[] { "UrunID" });
            DropIndex("dbo.SatisDetaylar", new[] { "SatisID" });
            DropIndex("dbo.Satislar", new[] { "CalisanID" });
            DropTable("dbo.Tedarikciler");
            DropTable("dbo.Siparisler");
            DropTable("dbo.SiparisDetaylar");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Urunler");
            DropTable("dbo.SatisDetaylar");
            DropTable("dbo.Satislar");
            DropTable("dbo.Calisanlar");
        }
    }
}

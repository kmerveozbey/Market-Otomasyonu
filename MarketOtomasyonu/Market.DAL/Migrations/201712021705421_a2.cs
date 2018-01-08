namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunler", "SatisFiyati", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Urunler", "AlisFiyati");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Urunler", "AlisFiyati", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Urunler", "SatisFiyati");
        }
    }
}

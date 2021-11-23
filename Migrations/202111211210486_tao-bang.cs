namespace DangKhieuTrungThanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class taobang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        PassWord = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.LopHoc",
                c => new
                    {
                        MaLop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaLop);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonId = c.String(nullable: false, maxLength: 20),
                        PersonName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.SinhVien",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 20, unicode: false),
                        HoTen = c.String(nullable: false, maxLength: 50),
                        MaLop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSinhVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SinhVien");
            DropTable("dbo.Person");
            DropTable("dbo.LopHoc");
            DropTable("dbo.Accounts");
        }
    }
}

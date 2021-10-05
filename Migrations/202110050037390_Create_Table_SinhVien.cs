namespace DangKhieuTrungThanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_SinhVien : DbMigration
    {
        public override void Up()
        {

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
        }
    }
}

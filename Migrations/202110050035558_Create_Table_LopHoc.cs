namespace DangKhieuTrungThanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Malop : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHoc",
                c => new
                    {
                        MaLop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaLop);    
        }
        
        public override void Down()
        {
            DropTable("dbo.LopHoc");
        }
    }
}

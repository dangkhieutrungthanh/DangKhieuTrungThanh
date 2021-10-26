namespace DangKhieuTrungThanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.person",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        PersonName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.person");
        }
    }
}

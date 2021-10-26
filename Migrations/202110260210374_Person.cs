namespace DangKhieuTrungThanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Person : DbMigration
    {
        public override void Up()
        {        
            CreateTable(
               "dbo.Person",
               c => new
               {
                   PersonId = c.String(nullable: false, maxLength: 20, unicode: false),
                   PersonName = c.String(nullable: false, maxLength: 50),
                  
               })
               .PrimaryKey(t => t.PersonId);
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Person");
            
        }
    }
}

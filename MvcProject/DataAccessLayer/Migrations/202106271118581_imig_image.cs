namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imig_image : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImageFiles",
                c => new
                    {
                        ImgID = c.Int(nullable: false, identity: true),
                        ImgName = c.String(maxLength: 100),
                        ImgPatg = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ImgID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ImageFiles");
        }
    }
}

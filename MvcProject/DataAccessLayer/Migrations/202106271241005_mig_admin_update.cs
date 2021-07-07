namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_admin_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdminUserName", c => c.String(maxLength: 50));
            AddColumn("dbo.Admins", "AdminPassword", c => c.String(maxLength: 50));
            DropColumn("dbo.Admins", "AdminName");
            DropColumn("dbo.Admins", "AdminSurname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "AdminSurname", c => c.String(maxLength: 50));
            AddColumn("dbo.Admins", "AdminName", c => c.String(maxLength: 50));
            DropColumn("dbo.Admins", "AdminPassword");
            DropColumn("dbo.Admins", "AdminUserName");
        }
    }
}

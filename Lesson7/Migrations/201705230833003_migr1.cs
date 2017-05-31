namespace Lesson7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.Users", "Login", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "Login");
            DropColumn("dbo.Users", "LoginId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "LoginId", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Users");
            DropColumn("dbo.Users", "Login");
            AddPrimaryKey("dbo.Users", "LoginId");
        }
    }
}

namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otroscampos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "User", c => c.String());
            AddColumn("dbo.Posts", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Date");
            DropColumn("dbo.Posts", "User");
        }
    }
}

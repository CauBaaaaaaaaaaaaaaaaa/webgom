namespace Webbangom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mains", "note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mains", "note");
        }
    }
}

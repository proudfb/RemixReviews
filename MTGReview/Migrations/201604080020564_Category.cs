namespace RemixReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Category : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musics", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musics", "Category");
        }
    }
}

namespace WissenMVCProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesAtBaseEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "UpdatedBy", c => c.String());
            AddColumn("dbo.Posts", "UpdatedBy", c => c.String());
            AlterColumn("dbo.Categories", "CreatedBy", c => c.String());
            AlterColumn("dbo.Posts", "CreatedBy", c => c.String());
            DropColumn("dbo.Categories", "UpdateBy");
            DropColumn("dbo.Posts", "UpdateBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "UpdateBy", c => c.Int(nullable: false));
            AddColumn("dbo.Categories", "UpdateBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Posts", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "CreatedBy", c => c.Int(nullable: false));
            DropColumn("dbo.Posts", "UpdatedBy");
            DropColumn("dbo.Categories", "UpdatedBy");
        }
    }
}

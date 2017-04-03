namespace VSTDA.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDataTypeOfText : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TodoItems", "Text", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TodoItems", "Text", c => c.Int(nullable: false));
        }
    }
}

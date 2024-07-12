namespace M5C11_W01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class u : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TaskLists", "Submitedby", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TaskLists", "Submitedby");
        }
    }
}

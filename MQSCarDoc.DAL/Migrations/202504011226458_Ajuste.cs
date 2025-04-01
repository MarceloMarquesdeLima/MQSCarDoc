namespace MQSCarDocFrontend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ajuste : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Marca", "Usuario_ID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Marca", "Usuario_ID", c => c.Int());
        }
    }
}

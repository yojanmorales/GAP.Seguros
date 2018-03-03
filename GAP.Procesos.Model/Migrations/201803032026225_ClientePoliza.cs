namespace GAP.Procesos.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientePoliza : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Polizas", "ClienteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Polizas", "ClienteId");
            AddForeignKey("dbo.Polizas", "ClienteId", "dbo.Clientes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Polizas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Polizas", new[] { "ClienteId" });
            DropColumn("dbo.Polizas", "ClienteId");
        }
    }
}

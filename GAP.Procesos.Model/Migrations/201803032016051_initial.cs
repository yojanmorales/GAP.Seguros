namespace GAP.Procesos.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 200),
                        Identificacion = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Polizas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 200),
                        Descripción = c.String(nullable: false, maxLength: 200),
                        TipoCubrimientoId = c.Int(nullable: false),
                        Cobertura = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vigencia = c.DateTime(nullable: false),
                        Periodo = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Riesgo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoCubrimientos", t => t.TipoCubrimientoId, cascadeDelete: true)
                .Index(t => t.TipoCubrimientoId);
            
            CreateTable(
                "dbo.TipoCubrimientos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Polizas", "TipoCubrimientoId", "dbo.TipoCubrimientos");
            DropIndex("dbo.Polizas", new[] { "TipoCubrimientoId" });
            DropTable("dbo.TipoCubrimientos");
            DropTable("dbo.Polizas");
            DropTable("dbo.Clientes");
        }
    }
}

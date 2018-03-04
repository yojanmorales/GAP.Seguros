namespace GAP.Procesos.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiodescripcion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Polizas", "Descripcion", c => c.String(nullable: false, maxLength: 200));
            DropColumn("dbo.Polizas", "Descripción");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Polizas", "Descripción", c => c.String(nullable: false, maxLength: 200));
            DropColumn("dbo.Polizas", "Descripcion");
        }
    }
}

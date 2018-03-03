namespace GAP.Procesos.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class camposestadopoliza : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Polizas", "Estado", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Polizas", "Estado");
        }
    }
}

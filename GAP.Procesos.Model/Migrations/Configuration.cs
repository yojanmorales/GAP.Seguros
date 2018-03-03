namespace GAP.Procesos.Model.Migrations
{
    using GAP.Seguros.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GAP.Procesos.Model.Context.SegurosContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GAP.Procesos.Model.Context.SegurosContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.TipoCubrimiento.AddOrUpdate(x => x.Nombre,
                     new TipoCubrimiento() { Nombre = "Terremoto" },
                     new TipoCubrimiento() { Nombre = "Incendio" },
                     new TipoCubrimiento() { Nombre = "Robo" },
                     new TipoCubrimiento() { Nombre = "Pérdida" }
                     );

            context.Cliente.AddOrUpdate(x => x.Nombre,
                    new Cliente() { Nombre = "Elena Martinez", Identificacion = "1128" },
                    new Cliente() { Nombre = "Pedro Ramirez", Identificacion = "1129" }

                    );

        }
    }
}

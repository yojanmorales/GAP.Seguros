using GAP.Seguros.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.Procesos.Model.Context
{
    public class SegurosContext : DbContext
    {
        public SegurosContext() :
            base("SegurosContext")
        {
            Configure();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Database.SetInitializer(new MigrateDatabaseToLatestVersion<SegurosContext, Configuration>());
        }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Poliza> Poliza { get; set; }
        public virtual DbSet<TipoCubrimiento> TipoCubrimiento { get; set; }

        public void Configure()
        {
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = true;

        }
    }
}

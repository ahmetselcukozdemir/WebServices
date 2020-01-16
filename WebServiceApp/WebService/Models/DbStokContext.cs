using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WebService.Models.Mapping;

namespace WebService.Models
{
    public partial class DbStokContext : DbContext
    {
        static DbStokContext()
        {
            Database.SetInitializer<DbStokContext>(null);
        }

        public DbStokContext()
            : base("Name=DbStokContext")
        {
        }

        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<Musteriler> Musterilers { get; set; }
        public DbSet<Satislar> Satislars { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KategorilerMap());
            modelBuilder.Configurations.Add(new MusterilerMap());
            modelBuilder.Configurations.Add(new SatislarMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UrunlerMap());
        }
    }
}

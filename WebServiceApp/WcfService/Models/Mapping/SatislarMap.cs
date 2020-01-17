using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace WcfService.Models.Mapping
{
    public class SatislarMap : EntityTypeConfiguration<Satislar>
    {
        public SatislarMap()
        {
            // Primary Key
            this.HasKey(t => t.satisID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Satislar");
            this.Property(t => t.satisID).HasColumnName("satisID");
            this.Property(t => t.urunID).HasColumnName("urunID");
            this.Property(t => t.musteriID).HasColumnName("musteriID");
            this.Property(t => t.satisAdet).HasColumnName("satisAdet");
            this.Property(t => t.satisFiyat).HasColumnName("satisFiyat");

            // Relationships
            this.HasOptional(t => t.Musteriler)
                .WithMany(t => t.Satislars)
                .HasForeignKey(d => d.musteriID);
            this.HasOptional(t => t.Urunler)
                .WithMany(t => t.Satislars)
                .HasForeignKey(d => d.urunID);

        }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace WcfService.Models.Mapping
{
    public class UrunlerMap : EntityTypeConfiguration<Urunler>
    {
        public UrunlerMap()
        {
            // Primary Key
            this.HasKey(t => t.urunID);

            // Properties
            this.Property(t => t.urunAd)
                .HasMaxLength(50);

            this.Property(t => t.urunMarka)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Urunler");
            this.Property(t => t.urunID).HasColumnName("urunID");
            this.Property(t => t.urunAd).HasColumnName("urunAd");
            this.Property(t => t.urunMarka).HasColumnName("urunMarka");
            this.Property(t => t.urunKategori).HasColumnName("urunKategori");
            this.Property(t => t.urunFiyat).HasColumnName("urunFiyat");
            this.Property(t => t.urunStok).HasColumnName("urunStok");

            // Relationships
            this.HasOptional(t => t.Kategoriler)
                .WithMany(t => t.Urunlers)
                .HasForeignKey(d => d.urunKategori);

        }
    }
}

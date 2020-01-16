using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace WebService.Models.Mapping
{
    public class MusterilerMap : EntityTypeConfiguration<Musteriler>
    {
        public MusterilerMap()
        {
            // Primary Key
            this.HasKey(t => t.musteriID);

            // Properties
            this.Property(t => t.musteriAd)
                .HasMaxLength(50);

            this.Property(t => t.musteriSoyad)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Musteriler");
            this.Property(t => t.musteriID).HasColumnName("musteriID");
            this.Property(t => t.musteriAd).HasColumnName("musteriAd");
            this.Property(t => t.musteriSoyad).HasColumnName("musteriSoyad");
        }
    }
}

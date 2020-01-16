using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace WebService.Models.Mapping
{
    public class KategorilerMap : EntityTypeConfiguration<Kategoriler>
    {
        public KategorilerMap()
        {
            // Primary Key
            this.HasKey(t => t.kategoriID);

            // Properties
            this.Property(t => t.kategoriAd)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Kategoriler");
            this.Property(t => t.kategoriID).HasColumnName("kategoriID");
            this.Property(t => t.kategoriAd).HasColumnName("kategoriAd");
        }
    }
}

using System;
using System.Collections.Generic;

namespace WebService.Models
{
    public partial class Urunler
    {
        public Urunler()
        {
            this.Satislars = new List<Satislar>();
        }

        public int urunID { get; set; }
        public string urunAd { get; set; }
        public string urunMarka { get; set; }
        public Nullable<short> urunKategori { get; set; }
        public Nullable<decimal> urunFiyat { get; set; }
        public Nullable<byte> urunStok { get; set; }
        public virtual Kategoriler Kategoriler { get; set; }
        public virtual ICollection<Satislar> Satislars { get; set; }
    }
}

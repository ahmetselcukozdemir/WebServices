using System;
using System.Collections.Generic;

namespace WcfService.Models
{
    public partial class Satislar
    {
        public int satisID { get; set; }
        public Nullable<int> urunID { get; set; }
        public Nullable<int> musteriID { get; set; }
        public Nullable<byte> satisAdet { get; set; }
        public Nullable<decimal> satisFiyat { get; set; }
        public virtual Musteriler Musteriler { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}

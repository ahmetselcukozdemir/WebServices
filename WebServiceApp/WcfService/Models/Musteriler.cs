using System;
using System.Collections.Generic;

namespace WcfService.Models
{
    public partial class Musteriler
    {
        public Musteriler()
        {
            this.Satislars = new List<Satislar>();
        }

        public int musteriID { get; set; }
        public string musteriAd { get; set; }
        public string musteriSoyad { get; set; }
        public virtual ICollection<Satislar> Satislars { get; set; }
    }
}

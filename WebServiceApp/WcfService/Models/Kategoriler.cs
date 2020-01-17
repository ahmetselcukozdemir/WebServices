using System;
using System.Collections.Generic;

namespace WcfService.Models
{
    public partial class Kategoriler
    {
        public Kategoriler()
        {
            this.Urunlers = new List<Urunler>();
        }

        public short kategoriID { get; set; }
        public string kategoriAd { get; set; }
        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class ProductDTO
    {
        public int urunID { get; set; }
        public string urunAd { get; set; }
        public string urunMarka { get; set; }
        public Nullable<short> urunKategori { get; set; }
        public Nullable<decimal> urunFiyat { get; set; }
        public Nullable<byte> urunStok { get; set; }
    }
}
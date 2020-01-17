using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class ProductDTO
    {
        [DataMember]
        public int urunID { get; set; }
        [DataMember]
        public string urunAd { get; set; }
        [DataMember]
        public string urunMarka { get; set; }
        [DataMember]
        public Nullable<short> urunKategori { get; set; }
        [DataMember]
        public Nullable<decimal> urunFiyat { get; set; }
        [DataMember]
        public Nullable<byte> urunStok { get; set; }
    }

}
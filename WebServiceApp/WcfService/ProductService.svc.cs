using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.Models;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {
        public string DoWork()
        {
            return "Merhaba WCF Servis";
        }

        public List<ProductDTO> ProductList()
        {
            DbStokContext context = new DbStokContext();
            return context.Urunlers.Select(i => new ProductDTO
            {
                urunAd = i.urunAd,
                urunFiyat = i.urunFiyat,
                urunStok = i.urunStok,
                urunKategori = i.urunKategori,
                urunMarka = i.urunMarka
            }).ToList();
        }

    }
}

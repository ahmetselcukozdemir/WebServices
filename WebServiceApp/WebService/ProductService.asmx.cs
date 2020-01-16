using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    using Models;
    /// <summary>
    /// Summary description for ProductService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductService : System.Web.Services.WebService
    {
        DbStokContext context = new DbStokContext();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<ProductDTO> ProductList()
        {
            return context.Urunlers.Select(x => new ProductDTO
            {
                urunAd = x.urunAd,
                urunMarka = x.urunMarka,
                urunKategori = x.urunKategori,
                urunFiyat = x.urunFiyat,
                urunStok = x.urunStok
            }).ToList();
        }
    }
}

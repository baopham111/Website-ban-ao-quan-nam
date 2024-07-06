using System.Collections.Generic;
using website_ban_ao_quan_nam_bao.Models;

namespace website_ban_ao_quan_nam_bao.Services
{
    public class PaidProductService
    {
        private List<Product> paidProducts = new List<Product>();

        public void AddPaidProduct(Product product)
        {
            paidProducts.Add(product);
        }

        public List<Product> GetPaidProducts()
        {
            return paidProducts;
        }
    }
}

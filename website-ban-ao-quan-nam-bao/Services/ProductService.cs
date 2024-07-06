using website_ban_ao_quan_nam_bao.Models;
using System.Collections.Generic;
using System.Linq;

namespace website_ban_ao_quan_nam_bao.Services
{
    public class ProductService
    {
        private List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "T-Shirt", Description = "Áo thun cotton thoải mái", Price = 20.00m, ImageUrl = "https://i.imgur.com/jzosRYV.jpeg" },
            new Product { Id = 2, Name = "Jeans", Description = "Quần jean denim sành điệu", Price = 40.00m, ImageUrl = "https://i.imgur.com/Th8gjV2.jpeg" },
            new Product { Id = 3, Name = "Jacket", Description = "Warm winter jacket", Price = 60.00m, ImageUrl = "https://i.imgur.com/pqzbnH7.png" },
            new Product { Id = 4, Name = "Sweater", Description = "Áo khoác mùa đông ấm áp", Price = 35.00m, ImageUrl = "https://i.imgur.com/8CYHmT7.jpeg" },
            new Product { Id = 5, Name = "Shorts", Description = "Casual summer shorts", Price = 25.00m, ImageUrl = "https://i.imgur.com/nBWgNhA.jpeg" },
            new Product { Id = 6, Name = "Shirt", Description = "Quần short mùa hè giản dị", Price = 30.00m, ImageUrl = "https://i.imgur.com/QZsiX54.jpeg" },
            new Product { Id = 7, Name = "Blazer", Description = "Blazer thanh lịch", Price = 70.00m, ImageUrl = "https://i.imgur.com/hsHggQ4.jpeg" },
            new Product { Id = 8, Name = "Tie", Description = "Silk tie", Price = 15.00m, ImageUrl = "https://i.imgur.com/n4frbw9.jpeg" },
            new Product { Id = 9, Name = "Polo", Description = "Cà vạt lụa", Price = 22.00m, ImageUrl = "https://i.imgur.com/YsKWAy9.jpeg" },
            new Product { Id = 10, Name = "Tracksuit", Description = "Bộ đồ thể thao thoải mái", Price = 50.00m, ImageUrl = "https://i.imgur.com/3GVHBut.jpeg" },
             new Product { Id = 11, Name = "Cap", Description = "mũ lưỡi trai sành điệu", Price = 10.00m, ImageUrl = "https://i.imgur.com/BGDm2aD.jpeg" },
            new Product { Id = 12, Name = "Socks", Description = "Comfortable socks", Price = 5.00m, ImageUrl = "https://i.imgur.com/oq7Cn4s.jpeg" },
         
        };

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> SearchProducts(string query)
        {
            return products.Where(p => p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public void AddProduct(Product product)
        {
            product.Id = products.Max(p => p.Id) + 1;
            products.Add(product);
        }
    }
}

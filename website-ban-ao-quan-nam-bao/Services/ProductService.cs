using website_ban_ao_quan_nam_bao.Models;
using System.Collections.Generic;
using System.Linq;

namespace website_ban_ao_quan_nam_bao.Services
{
    public class ProductService
    {
        private List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "T-Shirt", Description = "Áo thun cotton thoải mái, mềm mại và thoáng mát, lý tưởng cho những ngày hè nóng bức. Thiết kế đơn giản nhưng hiện đại, phù hợp với mọi phong cách thời trang.", Price = 20.00m, ImageUrl = "https://i.imgur.com/YpP8em1.jpeg" },
            new Product { Id = 2, Name = "Jeans", Description = "Quần jean denim sành điệu với chất liệu bền chắc, phù hợp cho cả nam và nữ. Thiết kế cổ điển, dễ dàng phối hợp với các loại áo khác nhau, tạo nên phong cách trẻ trung và năng động.", Price = 40.00m, ImageUrl = "https://i.imgur.com/PYkF8m4.jpeg" },
            new Product { Id = 3, Name = "Jacket", Description = "Áo khoác  được làm từ chất liệu cao cấp, đảm bảo sự thoải mái và ấm áp cho người mặc.", Price = 60.00m, ImageUrl = "https://i.imgur.com/c3iCjAX.jpeg" },
            new Product { Id = 4, Name = "Sweater", Description = "Áo khoác mùa đông ấm áp, phù hợp với các hoạt động ngoài trời. Chất liệu len dày dặn, mềm mại, giữ nhiệt tốt. Thiết kế thời trang, dễ dàng kết hợp với các trang phục khác.", Price = 35.00m, ImageUrl = "https://i.imgur.com/8CYHmT7.jpeg" },
            new Product { Id = 5, Name = "Shorts", Description = "Quần short mùa hè giản dị, thoải mái với chất liệu cotton thoáng mát. Thiết kế đơn giản, phù hợp với các hoạt động thể thao hay dạo phố.", Price = 25.00m, ImageUrl = "https://i.imgur.com/UDotMVL.jpeg" },
            new Product { Id = 6, Name = "Shirt", Description = "Áo sơ mi phong cách lịch lãm, chất liệu thoáng mát, dễ chịu. Thiết kế hiện đại, phù hợp với các buổi tiệc hay họp mặt trang trọng.", Price = 30.00m, ImageUrl = "https://i.imgur.com/QZsiX54.jpeg" },
            new Product { Id = 7, Name = "Blazer", Description = "Blazer thanh lịch, chất liệu vải cao cấp, cắt may tỉ mỉ. Phù hợp với các dịp đặc biệt hoặc môi trường làm việc chuyên nghiệp.", Price = 70.00m, ImageUrl = "https://i.imgur.com/hsHggQ4.jpeg" },
            new Product { Id = 8, Name = "Tie", Description = "Áo Polo thời trang, chất liệu cotton thoáng mát sang trọng", Price = 15.00m, ImageUrl = "https://i.imgur.com/jkDJ3Pe.jpeg" },
            new Product { Id = 9, Name = "Polo", Description = "Áo Polo thời trang, chất liệu cotton thoáng mát, thích hợp cho cả công việc và các hoạt động thường ngày. Thiết kế cổ điển với cổ áo bẻ, tạo phong cách lịch sự nhưng không kém phần thoải mái.", Price = 22.00m, ImageUrl = "https://i.imgur.com/YsKWAy9.jpeg" },
            new Product { Id = 10, Name = "Tracksuit", Description = "Bộ đồ thể thao thoải mái, chất liệu thun co giãn, phù hợp cho các hoạt động thể thao và vận động. Thiết kế hiện đại với màu sắc trẻ trung, dễ dàng kết hợp với giày thể thao.", Price = 50.00m, ImageUrl = "https://i.imgur.com/3GVHBut.jpeg" },
            new Product { Id = 11, Name = "Cap", Description = "Mũ lưỡi trai sành điệu, chất liệu vải bền đẹp, dễ dàng điều chỉnh kích cỡ. Phù hợp cho các hoạt động ngoài trời, bảo vệ bạn khỏi ánh nắng.", Price = 10.00m, ImageUrl = "https://i.imgur.com/BGDm2aD.jpeg" },
            new Product { Id = 12, Name = "Socks", Description = "Đôi tất thoải mái, chất liệu cotton mềm mại, thoáng khí. Thiết kế đơn giản, phù hợp với nhiều loại giày khác nhau, giúp chân bạn luôn thoải mái cả ngày dài.", Price = 5.00m, ImageUrl = "https://i.imgur.com/oq7Cn4s.jpeg" },
            new Product { Id = 13, Name = "Hoodie", Description = "Áo hoodie thời trang, chất liệu nỉ mềm mại, thoáng mát. Thiết kế trẻ trung với túi trước tiện lợi, phù hợp cho các hoạt động ngoài trời hay dạo phố.", Price = 45.00m, ImageUrl = "https://i.imgur.com/HEX3YdG.jpeg" },
            new Product { Id = 14, Name = "Jogger Pants", Description = "Quần jogger trẻ trung, chất liệu thun co giãn, thoải mái. Thiết kế đơn giản nhưng hiện đại, phù hợp với nhiều phong cách thời trang khác nhau.", Price = 35.00m, ImageUrl = "https://i.imgur.com/AjKaSjy.jpeg" },
            new Product { Id = 15, Name = "Bomber Jacket", Description = "Áo khoác bomber phong cách, chất liệu vải dày dặn, ấm áp. Thiết kế năng động, dễ dàng phối đồ, tạo nên vẻ ngoài hiện đại và cá tính.", Price = 55.00m, ImageUrl = "https://i.imgur.com/gJQB0IG.jpeg" }

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

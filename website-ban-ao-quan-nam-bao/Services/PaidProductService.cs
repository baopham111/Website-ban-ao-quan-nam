using website_ban_ao_quan_nam_bao.Models;
using System.Collections.Generic;
using static website_ban_ao_quan_nam_bao.Pages.Checkout;

namespace website_ban_ao_quan_nam_bao.Services
{
    public class PaidProductService
    {
        // Danh sách sản phẩm đã thanh toán và thông tin khách hàng
        private List<(Product Product, ThongTinKhachHang CustomerInfo)> paidProducts = new List<(Product, ThongTinKhachHang)>();

        // Phương thức thêm sản phẩm đã thanh toán với thông tin khách hàng
        public void AddPaidProduct(Product product, ThongTinKhachHang customerInfo)
        {
            paidProducts.Add((product, customerInfo));
        }

        // Lấy danh sách sản phẩm đã thanh toán cùng với thông tin khách hàng
        public List<(Product Product, ThongTinKhachHang CustomerInfo)> GetPaidProducts()
        {
            return paidProducts;
        }
    }
}

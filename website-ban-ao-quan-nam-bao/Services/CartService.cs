using website_ban_ao_quan_nam_bao.Models;
using System.Collections.Generic;
using System.Linq;

namespace website_ban_ao_quan_nam_bao.Services
{
    public class CartService
    {
        private List<CartItem> cartItems = new List<CartItem>();

        public void AddToCart(Product product)
        {
            var cartItem = cartItems.FirstOrDefault(ci => ci.Product.Id == product.Id);
            if (cartItem != null)
            {
                cartItem.Quantity++;
            }
            else
            {
                cartItems.Add(new CartItem { Product = product, Quantity = 1 });
            }
        }

        public List<CartItem> GetCartItems()
        {
            return cartItems;
        }

        public void ClearCart()
        {
            cartItems.Clear();
        }
    }

    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}

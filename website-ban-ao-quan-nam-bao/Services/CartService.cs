using website_ban_ao_quan_nam_bao.Models;
using System.Collections.Generic;

namespace website_ban_ao_quan_nam_bao.Services
{
    public class CartService
    {
        private List<CartItem> cartItems = new List<CartItem>();

        public void AddToCart(Product product, int quantity)
        {
            var existingItem = cartItems.Find(item => item.Product.Id == product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                cartItems.Add(new CartItem { Product = product, Quantity = quantity });
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

﻿namespace Web_CaPhe.Models.Interface
{
    public interface IShoppingCartRepository
    {
        void AddToCart(Product product);
        int RemoveFromCart(Product product);
        List<ShoppingCartItem> GetAllShoppingCartItems();
        void ClearCart();
        
        decimal GetShoppingCartTotal();
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}

using CKK.Logic.Models;
using System;
using Xunit;

namespace ShoppingCartTest
{
    public class ShoppingCart
    {
        [Fact]
        public void AddProduct()
        {
            var cart = new ShoppingCart();
            var item1 = new Product() { Id = "124869", Name = "shirt", Price = 25 };

            ShoppingCart.AddProduct(item1, 1);

            Assert.True(ShoppingCart.Contains(item1));
        }

        [Fact]
        public void RemoveProduct()
        {
            var cart = new ShoppingCart();
            cart.RemoveProduct();
        }
        [Fact]
        public void GetTotal()
        {
            var cart = new ShoppingCart();
            cart.GetTotal();
        }
    }
}

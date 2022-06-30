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
            var product = new Product();

            var actual = Product.product("1");

            Assert.Equal(1, actual);

        }
    }
}

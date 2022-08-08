using System;
using System.Collections.Generic;
using System.Text;

namespace CKK.Logic.Models
{
    class ShoppingCart
    {
        private Customer _customer;
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;

        public int customerId { get; private set; }

        public ShoppingCart(Customer customer)
        {
            _customer = customer;
        }

        public int GetCustomerId()
        {
            return customerId;
        }

        public void GetProductById(ShoppingCartItem id)
        {

        }

        public void AddProduct(ShoppingCartItem product)
        {
            if (ShoppingCart.Contains(product))
                return;

            ShoppingCart.Add(product);

        }
        public void AddProduct(ShoppingCartItem product, int quantity)
        {
            
        }

        public void RemoveProduct(Product product, int quantity)
        {
            ShoppingCartItem.Remove(product);

        }

        public decimal GetTotal()
        {
            return _product1.GetTotal();
        }


        public void GetProduct(int productNumber)
        {

        }
    }
}

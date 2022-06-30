using System;
using System.Collections.Generic;
using System.Text;

namespace CKK.Logic.Models
{
    class ShoppingCart
    {
        private Customer _customer;
        private Product _product1;
        private Product _product2;
        private Product _product3;
        private int customerId;

        public ShoppingCart(Customer customer)
        {
            _customer = customer;
        }

        public int GetCustomerId()
        {
            return customerId;
        }

        public void AddProduct(Product product)
        {
            if (_product1 == null)
            {
                _product1 = product;
            }
            else if (_product2 == null)
            {
                _product2 = product;
            }
            else if (_product3 == null)
            {
                _product3 = product;
            }

        }
    }
}

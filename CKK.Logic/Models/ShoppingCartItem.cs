

namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        private Product _product;
        private int _quantity;
        private Product product1;
        private Product product2;

        //public int Quantity { get; internal set; }

        public ShoppingCartItem(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        public ShoppingCartItem(Product product1, Product product2)
        {
            this.product1 = product1;
            this.product2 = product2;
        }

        public Product GetProduct()
        {
            return _product;
        }
        public void SetProduct(Product product)
        {
            _product = product;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }
       
        public decimal GetTotal()
        {
            return _product.GetPrice() * _quantity;
        }
    }
}

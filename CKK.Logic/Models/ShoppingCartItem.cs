

namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        private Product _product;
        private int _quantity;
        private int _price;
     

        public ShoppingCartItem(Product product, int quantity, int price)
        {
            _product = product;
            _quantity = quantity;
            _price = price;

        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }
        public Product GetProduct()
        {
            return _product;
        }
        public void SetProduct(Product product)
        {
            _product = product;
        }
        public int GetPrice()
        {
            return _price;
        }
        public void SetPrice(int price)
        {
            _price = price;
        }
        public decimal GetTotalPrice()
        {
            return _quantity * _price;
        }
    }
}

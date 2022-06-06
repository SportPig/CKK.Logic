

namespace CKK.Logic.Models
{
    public class StoreItem
    {
        private Product _product;
        private int _quantity { get; set; }

        public StoreItem(Product product, int Quantity)
        {
            _product = product;
            _quantity = Quantity;
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
    }
}

using System;


namespace CKK.Logic.Models
{
    public class Product
    {
        private int id;
        private string _name;
        private decimal _price;
      

        public Product(int id, string name, decimal price)
        {
            this.id = id;
            _name = name;
            _price = price;
        }

        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public decimal GetPrice()
        {
            return _price;
        }
        public void SetPrice(decimal price)
        {
            _price = price;
        }
      
        public Product()
        {

        }

        
    }

}

using System;


namespace CKK.Logic.Models
{
    public class Product
    {
        private int _Id;
        private string _name;
        private decimal _price;
        private int v1;
        private int id;
        private string v2;
        private string name;

        public Product(int id, string name, decimal price)
        {
            _Id = id;
            _name = name;
            _price = price;
        }

        public int GetId()
        {
            return _Id;
        }
        public void SetId(int id)
        {
            _Id = id;
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

using System;
using System.Collections.Generic;
using System.Text;

namespace CKK.Logic.Models
{
    public class AddStoreItem
    {
        private int _Id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;
        private int _productNumber;

        public AddStoreItem(int id, string name, Product product1, Product product2, Product product3, int productNumber)
        {
            _Id = id;
            _name = name;
            _product1 = product1;
            _product2 = product2;
            _product3 = product3;
            _productNumber = productNumber;
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
        public AddStoreItem(Product product)
        {
            
        }
        public void RemoveStoreItem(int productNumber)
        {

        }
        public void GetStoreItem(int productNumber)
        {

        }
        public void FindStoreItemById(int id)
        {

        }
        
    }
}


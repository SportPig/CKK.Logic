using System;
using System.Collections.Generic;
using System.Text;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;
        

        public Store(int id, string name, Product product1, Product product2, Product product3)
        {
            this.id = id;
            _name = name;
            _product1 = product1;
            _product2 = product2;
            _product3 = product3;
           
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
        public void AddStoreItem(Product product)
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
        public void RemoveStoreItem(int productNumber)
        {
            if(productNumber == 1)
            {
                _product1 = null;
            }
            else if (productNumber == 2)
            {
                _product2 = null;
            }
            else if (productNumber == 3)
            {
                _product3 = null;
            }
        }
        public Product GetStoreItem(int productNumber)
        {
            if (productNumber == 1)
            {
                return _product1;
            }
            else if (productNumber == 2)
            {
                return _product2;
            }
            else if (productNumber == 3)
            {
                return _product3;
            }
            return null;
        }
        public Product FindStoreItemById(int id)
        {
            if (_product1 != null)
            {
                if (_product1.GetId() == id)
                {
                    return _product1;
                }

                }   
                if (_product2 != null)
                {
                    if (_product2.GetId() == id)
                    {
                        return _product2;
                    }
                }
                if (_product3 != null)
                {
                    if (_product3.GetId() == id)
                    {
                        return _product3;
                    }
                }
                return null;
            }

        }

    }



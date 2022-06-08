using System;
using System.Collections.Generic;
using System.Text;


namespace CKK.Logic.Models
{
    public class Customer
    {
        private int id;
        private string _name;
        private string _address;

        public Customer(int id, string name, string address)
        {
            this.id = id;
            _name = name;
            _address = address;
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
        public string GetAddress()
        {
            return _address;
        }
        public void SetAddress(string address)
        {
            _address = address;
        }

        public Customer()
        {
        }
    }
}

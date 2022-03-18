using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Customer
    #region Instance Field
    {
        private string _name;
        public string _cname;
        #endregion

        #region Properties
        public string cName
        {
            get { return _cname; }
            set { _cname = value; }
        }

        public Customer(string name)
        {
            _cname = name;
        }
        public string Name
        {
            get { return _name; }
        }
        #endregion 
    }
}
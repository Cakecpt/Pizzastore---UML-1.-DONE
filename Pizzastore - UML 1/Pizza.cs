using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Pizza
    {
        #region Instancefield
        public string _name;
        public string _taxpct;
        private double _price;
        public double _tax = 1.25;
        public double _delivery = 40;

        #endregion

        #region Constructer
        public Pizza()
        {
            _name = "";
            _price = 0;
            _taxpct = "25%";
        }

        public Pizza(string name, double price)
        {
            _name = name;
            _price = price;
        }

        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Name: {Name} - Price {Price}";
        }
        #endregion 
    }
}

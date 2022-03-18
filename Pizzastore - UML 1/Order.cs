using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Order

    #region Instancefield
    {
        double _tax = 1.25;
        double _delivery = 40;
        double _price;
        string _name;
        string _cname;
        Pizza p;
        Customer c;
        #endregion

        #region Constructer
        public Order(Pizza pizza, Customer customer)
        {
            _price = pizza.Price;
            _name = pizza.Name;
            _cname = customer.cName;
            p = pizza;
        }
        #endregion

        #region Properties
        double tax
        {
            get { return _tax; }
            set { _tax = value; }
        }

        double DeliveryCosts
        {
            get { return _delivery; }
            set { _delivery = value; }
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Customer: {_cname} - Pizza: {_name} - TaxPct: {_tax} - Delivery cost: {_delivery} - Total: {CalculateTotalPrice()}";
        }

        public double CalculateTotalPrice()
        {
            return (p.Price * _tax) + _delivery;
        }
        #endregion
    }
}
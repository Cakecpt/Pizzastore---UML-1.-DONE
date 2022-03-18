using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Store
    {
        public void Start()
        {
            Pizza P1 = new Pizza("Margherita Pizza", 60);
            Pizza P2 = new Pizza("Pepperoni Pizza", 70);
            Pizza P3 = new Pizza("Salat Pizza", 65);
            Pizza P4 = new Pizza("Stor Pizza Menu", 125);

            Customer C1 = new Customer("Jens");
            Customer C2 = new Customer("Ruben");
            Customer C3 = new Customer("Kaya");

            Order O1 = new Order(P1, C2);
            Order O2 = new Order(P2, C1);
            Order O3 = new Order(P3, C3);
            Order O4 = new Order(P4, C3);

            Console.WriteLine(O1);
            Console.WriteLine(O2);
            Console.WriteLine(O3);
            Console.WriteLine(O4);
        }



    }
}

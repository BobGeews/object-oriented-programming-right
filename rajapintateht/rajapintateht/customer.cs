using System;
using System.Collections.Generic;
using System.Text;

namespace rajapintateht
{
    class customer : Icustomers
    {
        public string customerName;
        public double items;

        public customer()
        {
            this.customerName = "";
            this.items = 0.0;
        }
        public customer(string customerName, double items)
        {
            this.customerName = customerName;
            this.items = items;
        }
        public override string ToString()
        {
            return $"Asiakas: {this.customerName}\n Tuotteiden arvo yht. {this.items}";
        }
        public Object GetCustomer(string comparedName)
        {
            if (customerName == comparedName)
            {
                return this;


            }
            else
            {
                return null;
            }
        }
        public double GetBonus()
        {
           if (this.items<1000)
            {

                double bonus = this.items * 0.02;
                return bonus;
                
            }
           else if (this.items>=1000 && this.items<2000)
            {
                double bonus = this.items * 0.03;
                return bonus;
            }
           else
            {
                double bonus = this.items * 0.05;
                return bonus;
            }

        }
    }
}

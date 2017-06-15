using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Classes
{
    class FuelPurchase
    {
        public int litres_purchased { get; set; }
        public double total_cost { get; set; }

        public FuelPurchase(int ltrs)
        {
            litres_purchased = ltrs;
            total_cost = (litres_purchased * 1.20);

        }
    }
}

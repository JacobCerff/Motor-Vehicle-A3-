using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Classes
{
    public class PerDayRental
    {
        public PerDayRental(double days, double kmt)
        {
            Days = days;
            KMT = kmt;
            Rate = 100.00;
        }
        public double Days { get; set; }
        public double KMT {  get; set; }
        public double Rate { get; set; }
        public double Charge()
        {
            double result;
            result = Rate * Days;
            return result;
        }
    }
}

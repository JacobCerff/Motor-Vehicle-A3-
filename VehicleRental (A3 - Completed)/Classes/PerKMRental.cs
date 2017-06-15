using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Classes
{
    public class PerKMRental
    {
        public PerKMRental(double kms)
        {
            KMS = kms;
            Rate = 1.00;
        }
        public double KMS {get; set;}
        public double Rate { get; set; }
        public double Charge()
        {
            double result;
            result = Rate * KMS;
            return result;
        }
    }
}

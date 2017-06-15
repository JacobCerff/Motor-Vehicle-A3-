using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Classes
{
    public class Vehicle
    {
        public Vehicle() { }
        public Vehicle( string manufacturer, string model, string make, string regno, double totalkmt, double tlpurchased, int serv, double kmserv, double fuelecon)
        {
            manufacturer = Manufacturer;
            model = Model;
            make = Make;
            regno = RegNo;
            TotalKMT = totalkmt;
            KMServ = KMServ;
            TLpurchased = TLpurchased;
            Serv = serv;
            Fuel_econ = fuelecon;
        }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Make { get; set; } //Year
        public string RegNo { get; set; } //registration number
        public double TotalKMT { get; set; } //Total kilometres travelled
        public int TLpurchased { get; set; } //Total litres purchased
        public int Serv { get; set; } //Services had
        public bool ServREQ(double TotalKMT)
        {
            if ((KMServ / 100) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            } //whether or not a service is required
        }
        public double KMServ { get; set; } //kilometres since last service, equal to KMT until service resets it.
        public double Fuel_econ { get; set; } //per 100km
        public double  Revenue { get; set; } // Total Revenue 
        public double AddJourney(Journey journey)
        {
            double result = journey.KMT + TotalKMT;
            return result;
        }
        public int AddFuel(int ltrs)
        {
            int fuel = ltrs +TLpurchased;
            return fuel;
        }
        public double CalcFuelEcon()
        {
            Fuel_econ = (TLpurchased * 100) / TotalKMT;
            return Fuel_econ;
        }
        public double AddRevenue(PerKMRental rental)
        {
            double result;
            result = Revenue += rental.Charge();
            return result;
        }
        public double AddRevenue(PerDayRental rental)
        {
            double result;
            result = Revenue += rental.Charge();
            return result;
        }
        public string PrintToScreen() //Format for vehicle report
        {
            string output =
                "Manufacturer: " + Manufacturer +
                "\nModel: " + Model +
                "\nProduction Date: " + Make +
                "\nRegistration: " + RegNo +
                "\nTotal Km Travelled: " + TotalKMT +
                "\nTotal Litres of Fuel:" + TLpurchased +            
                "\nFuel Economy: " + Fuel_econ + "/100km" +
                "\nTotal Services: " + Serv +
                "\nKilometres since last service: " + KMServ +
                "\nService Required: " + ServREQ(TotalKMT) +
                "\nTotal Revenue: " + Revenue;
            return output;
        }
    }
}

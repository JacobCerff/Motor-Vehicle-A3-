using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add classes
using VehicleRental.Classes;

namespace VehicleRental
{
    public partial class Main : Form
    {
        Vehicle[] Vehicles = new Vehicle[3]; //Object array for vehicles

        public Main()
        {
            InitializeComponent();
            InitializeVehicles();
            cbVehicles.SelectedIndex = 0;
            rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen();
        }
        public void InitializeVehicles()
        {
            Vehicle VehicleTemp1 = new Vehicle();
            Vehicle VehicleTemp2 = new Vehicle();
            Vehicle VehicleTemp3 = new Vehicle();

            // Initialize values for Vehicle 0
            VehicleTemp1.Manufacturer = "Audi";
            VehicleTemp1.Model = "A6";
            VehicleTemp1.Make = "2003";
            VehicleTemp1.RegNo = "1 ABC 221";
            VehicleTemp1.TotalKMT = 0;
            VehicleTemp1.Serv = 0;
            VehicleTemp1.KMServ = 0;
            VehicleTemp1.Fuel_econ = VehicleTemp1.CalcFuelEcon();

            Vehicles[0] = VehicleTemp1; // add to the array

            // Initialize values for Vehicle 1
            VehicleTemp2.Manufacturer = "Ford";
            VehicleTemp2.Model = "T812";
            VehicleTemp2.Make = "2014";
            VehicleTemp2.RegNo = "1 ABD 760";
            VehicleTemp2.TotalKMT = 0;
            VehicleTemp2.Serv = 0;
            VehicleTemp1.KMServ = 0;
            VehicleTemp2.Fuel_econ = VehicleTemp2.CalcFuelEcon();


            Vehicles[1] = VehicleTemp2; // add to the array

            // Initialize vaues for Vehicle 2
            VehicleTemp3.Manufacturer = "Jaguar";
            VehicleTemp3.Model = "X200";
            VehicleTemp3.Make = "2003";
            VehicleTemp3.RegNo = "1 ABG 432";
            VehicleTemp3.TotalKMT = 0;
            VehicleTemp3.Serv = 0;
            VehicleTemp1.KMServ = 0;
            VehicleTemp3.Fuel_econ = VehicleTemp3.CalcFuelEcon();

            Vehicles[2] = VehicleTemp3; // add to the array
        }

        private void btnPerKM_Click(object sender, EventArgs e)
        {
                double num;
                bool result = double.TryParse(txtJourney.Text, out num);
                if (result && num >= 0)
                {
                    Journey journey = new Journey(num);
                    PerKMRental perkmrental = new PerKMRental(num);
                    //Order is important here KMserv has to be updated before TotalKM otherwise they would get different results
                    Vehicles[cbVehicles.SelectedIndex].KMServ = Vehicles[cbVehicles.SelectedIndex].AddJourney(journey);
                    Vehicles[cbVehicles.SelectedIndex].TotalKMT = Vehicles[cbVehicles.SelectedIndex].AddJourney(journey);
                    Vehicles[cbVehicles.SelectedIndex].Revenue = Vehicles[cbVehicles.SelectedIndex].AddRevenue(perkmrental);
                    Vehicles[cbVehicles.SelectedIndex].CalcFuelEcon();
                    rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen() + "\n\nJourney has been added.";
                }
                else
                {
                    MessageBox.Show("Please enter a valid number");
                }                   
        }

        private void btnAddFuel_Click(object sender, EventArgs e)
        {
                int num;
                bool result = int.TryParse(txtFuel.Text, out num);
                if (result)
                {
                    FuelPurchase fuel = new FuelPurchase(num);
                    Vehicles[cbVehicles.SelectedIndex].TLpurchased = Vehicles[cbVehicles.SelectedIndex].AddFuel(num);
                    Vehicles[cbVehicles.SelectedIndex].CalcFuelEcon();
                    rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen() + "\n\nTotal litres of fuel has been updated.";
                }
                else
                {
                    MessageBox.Show("Please enter a valid number");
                }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Vehicles[cbVehicles.SelectedIndex].CalcFuelEcon();
            rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            Vehicles[cbVehicles.SelectedIndex].Serv += 1;
            Vehicles[cbVehicles.SelectedIndex].KMServ = 0;
            rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen() + "\n\nVehicle has been serviced.";
        }

        private void btnPerDay_Click(object sender, EventArgs e)
        {
            double num;
            double days;
            bool Num = double.TryParse(txtJourney.Text, out num);
            bool Days = double.TryParse(txtDays.Text, out days);
            if (Num && num >= 0 && Days && days >= 0)
            {
                bool serv = Vehicles[cbVehicles.SelectedIndex].ServREQ(num);
                if (!serv)
                {
                    Journey journey = new Journey(num);
                    PerDayRental perdayrental = new PerDayRental(days, num);
                    //Order is important here KMserv has to be updated before TotalKM otherwise they would get different results
                    Vehicles[cbVehicles.SelectedIndex].KMServ = Vehicles[cbVehicles.SelectedIndex].AddJourney(journey);
                    Vehicles[cbVehicles.SelectedIndex].TotalKMT = Vehicles[cbVehicles.SelectedIndex].AddJourney(journey);
                    Vehicles[cbVehicles.SelectedIndex].Revenue = Vehicles[cbVehicles.SelectedIndex].AddRevenue(perdayrental);
                    Vehicles[cbVehicles.SelectedIndex].CalcFuelEcon();
                    rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen() + "\n\nJourney has been added.";
                }
                else
                {
                    MessageBox.Show("This Vehicle requires a service");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number in both fields.");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleRental.Classes;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //Default Values for vehicle
        double TKMT = 0;
        int TLP = 0;
        double kmserv = 0;
        double fuelecon = 0;

        //Litres for AddFuel
        int ltrs;

        //Kilometres traveled for journey and rental input
        double kmt = 0;

        //days for Rental
        int days = 0;

        //Test the CalcFuelEcon function
        [TestMethod]
        public void TestCalcFuelEcon()
        {
            //Arrange
            TKMT = 1200;
            TLP = 120;
            double expected = 10;
            var test = new Vehicle(TKMT, TLP, kmserv, fuelecon);

            //Act
            double actual = test.CalcFuelEcon();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Test the ServREQ function
        [TestMethod]
        public void TestServREQ()
        {
            //Arrange
            TKMT = 1000;
            kmserv = 1000;
            bool expected = true;
            var test = new Vehicle(TKMT, TLP, kmserv, fuelecon);

            //Act
            bool actual = test.ServREQ(TKMT);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Test the AddFuel function
        [TestMethod]
        public void TestAddFuel()
        {
            //Arrange
            TLP = 100;
            ltrs = 10;
            int expected = 110;
            var test = new Vehicle(TKMT, TLP, kmserv, fuelecon);

            //Act

            int actual = test.AddFuel(ltrs);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Test the AddJouney function
        [TestMethod]
        public void TestAddJourney()
        {
            //Arrange
            TKMT = 100;
            kmt = 100;
            Journey journey = new Journey(kmt);
            double expected = 200;
            var test = new Vehicle(TKMT, TLP, kmserv, fuelecon);

            //Act
            double actual = test.AddJourney(journey);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Test the AddRevenue(PerKmRental)
        [TestMethod]
        public void TestAddRevenueKM()
        {
            //Arrange
            kmt = 100;
            PerKMRental perkmrental = new PerKMRental(kmt);
            double expected = 100;
            var test = new Vehicle(TKMT, TLP, kmserv, fuelecon);

            //Act
            double actual = test.AddRevenue(perkmrental);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Test the AddRevenue(PerDayRental)
        [TestMethod]
        public void TestAddRevenueDay()
        {
            //Arrange
            days = 1;
            kmt = 50;
            PerDayRental perdayrental = new PerDayRental(days, kmt);
            double expected = 100;
            var test = new Vehicle(TKMT, TLP, kmserv, fuelecon);

            //Act
            double actual = test.AddRevenue(perdayrental);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Testing random input on AddRevenue(perDayRental)
        //Test the AddRevenue(PerDayRental)
        [TestMethod]
        public void TestAddRevenueDayInvalid()
        {
            //Arrange
            days = -1;
            kmt =  -50;
            PerDayRental perdayrental = new PerDayRental(days, kmt);
            double expected = 100;
            var test = new Vehicle(TKMT, TLP, kmserv, fuelecon);

            //Act
            double actual = test.AddRevenue(perdayrental);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

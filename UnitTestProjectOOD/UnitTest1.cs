using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientsNS;
using FuelPumpNS;
using FuelTankNS;

namespace UnitTestProjectOOD
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void AddAmountTest()
        {
            Client clienttest = new Client("Andrew","Jeep",123456,120,30);
            int amount = 120;
            int expectedResult = 240;
            clienttest.AddAmount(amount);
            int result = clienttest.BalanceOfClient;
            Assert.AreEqual(expectedResult, result);


        }

        [TestMethod]
        public void DeductAmountTest()
        {
            Client clienttest = new Client("Andrew", "Jeep", 123456, 120, 30);
            int amount = 30;
            int expectedResult = 90;
            clienttest.DeductAmount(amount);
            int result = clienttest.BalanceOfClient;
            Assert.AreEqual(expectedResult, result);


        }
    }

    [TestClass]
    public class FuelPumpTest
    {
        [TestMethod]
        public void CalculateLitersSoldTest()
        {
            FuelPump fp = new FuelPump(1, 1123);
            int newcounter = 1323;
            int expectedResult = 200;
            fp.CalculateLitersSold(fp.PreviousFuelPumpCounter, newcounter);
            int result = fp.LitersSold;
            Assert.AreEqual(expectedResult, result);
            

        }


    }

    [TestClass]
    
    public class FuelTankTest
    {
        [TestMethod]
        public void AddToTankTest()
        {
            FuelTank ft = new FuelTank(12000, 1);
            int amount = 2654;
            int expectedResult = 14654;
            ft.AddToTank(amount);
            int result = ft.AvailableQuantity;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void RemoveFromTank()
        {
            FuelTank ft = new FuelTank(15000, 1);
            int amount =6234;
            int expectedResult = 8766;
            ft.RemoveFromTank(amount);
            int result = ft.AvailableQuantity;
            Assert.AreEqual(expectedResult, result);
        }
    }




}

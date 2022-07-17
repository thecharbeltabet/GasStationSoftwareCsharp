using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FuelTankNS
{
    public class FuelTank
    {
        public int FuelTankNumber;
        public int AvailableQuantity;

        public FuelTank(int QA, int num)
        {
            AvailableQuantity = QA;
            FuelTankNumber = num;

        }

        public void AddToTank(int amount)
        {
            AvailableQuantity += amount;
        }

        public void RemoveFromTank(int amount)
        {
            AvailableQuantity -= amount;
        }
    }
}

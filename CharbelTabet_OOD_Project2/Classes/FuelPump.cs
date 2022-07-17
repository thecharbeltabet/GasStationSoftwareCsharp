using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelPumpNS
{
    public class FuelPump
    {
        public int FuelpumpNumber;
        public int PreviousFuelPumpCounter;
        public int LitersSold;
        

        public FuelPump(int num, int prevn)
        {
            FuelpumpNumber = num;
            PreviousFuelPumpCounter = prevn;
            LitersSold = 0;
            
        }
       
        public void CalculateLitersSold(int prevn,int newn)
        {
            if (newn > prevn)
            {
                LitersSold = newn - prevn;
            }
            else
                MessageBox.Show("New Counter Cannot be smaller than the previous one!");
        }

       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharbelTabet_OOD_Project2.Classes
{
    public class IncomeWExpenses: IincomeStrategy
    {
        public double CalculateIncome(int sales)
        {
            return (sales * 0.3) - 600;
        }

    }
}

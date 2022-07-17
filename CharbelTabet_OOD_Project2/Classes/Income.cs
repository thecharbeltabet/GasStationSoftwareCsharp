using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharbelTabet_OOD_Project2.Classes
{
    public class Income
    {
        IincomeStrategy CalculationType;
        
        public Income()
        {  }
        public void SetIncomeStrategy(IincomeStrategy incomestrategy) 
        { CalculationType = incomestrategy; }

        public IincomeStrategy GetIncomeStrategy() 
        { return CalculationType ; }

        public double CalculateIncome(int sales) 
        { return  this.CalculationType.CalculateIncome(sales); }
    }
}

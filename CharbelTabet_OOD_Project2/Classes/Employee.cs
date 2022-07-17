using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharbelTabet_OOD_Project2;
using AccountNS;

namespace EmployeeNS
{
    public class Employee: Account
    {
        public string TypeOfEmployee;
        public int SocialSecurityNumber;
        public int SalaryOfEmployee;

        public Employee(string fn, int age, string type,int ssn,int salary) : base()
        {
            FullName = fn;
            Age = age;
            TypeOfEmployee = type;
            SocialSecurityNumber = ssn;
            SalaryOfEmployee = salary;

        }

        public void AddAmount(int amount)
        {
            SalaryOfEmployee += amount;

        }

         public void DeductAmount(int amount) 
        {
            SalaryOfEmployee -= amount;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharbelTabet_OOD_Project2;
using AccountNS;

namespace ClientsNS
{
   public class Client : Account
    {
        public string CarOfClient;
        public int RegistrationNumber;
        public int BalanceOfClient;

        public Client(string fn,string car,int regNum, int balance, int age) : base()
        {
            FullName = fn;
            Age = age;
            CarOfClient = car;
            RegistrationNumber = regNum;
            BalanceOfClient = balance;
        }

        public void AddAmount(int amount)
        {
            BalanceOfClient += amount;

        }

        public void DeductAmount(int amount)
        {
            BalanceOfClient -= amount;
        }
    }
}

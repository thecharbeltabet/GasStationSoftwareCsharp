                using CharbelTabet_OOD_Project2.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelTankNS;
using ClientsNS;

namespace ManagerNS
{
    class Manager
    {
        private static Manager instance;
        private Manager() { }
        public static Manager GetInstance()
        {



            if (instance == null)
            {
                instance = new Manager();

                
            }
            return instance;
        }


        public void ClientFill(int amount, int liters, int tanknum,Client client)
        {
            MainForm.FuelTanks[tanknum - 1 ].RemoveFromTank(liters);
            client.AddAmount(amount);




        }
        

        




    }
}

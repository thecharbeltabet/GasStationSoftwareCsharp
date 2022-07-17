using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientsNS;
using AccountNS;
using EmployeeNS;
using FuelTankNS;
using FuelPumpNS;

namespace CharbelTabet_OOD_Project2.Forms
{
    public partial class MainForm : Form
    {

      

        public MainForm()
        {
            InitializeComponent();
            //Fill Tanks list
            FuelTanks.Add(Tank1);
            FuelTanks.Add(Tank2);
            FuelTanks.Add(Tank3);
            FuelTanks.Add(Tank4);

            //Fill Clients List
            ClientsList.Add(client1);
            ClientsList.Add(client2); 
            ClientsList.Add(client3); 
            ClientsList.Add(client4);
            ClientsList.Add(client5);
            ClientsList.Add(client6);


        }

        // Creating Clients
        public static Client client1 = new Client("Charbel Tabet", "Audi", 113112, 1000, 20);
        public static Client client2 = new Client("Elie Matar", "Fiat", 222333, 378, 19);
        public static Client client3 = new Client("Serge Habib", "GMC", 464646, 2987, 30);
        public static Client client4 = new Client("Joseph Akiki", "Porsche", 897132, 1227, 52);
        public static Client client5 = new Client("Joe Kassis", "BMW", 123456, 678, 37);
        public static Client client6 = new Client("Lynn Khoury", "Ferrari", 333333, 3265, 19);

        public static List<Client> ClientsList = new List<Client>();

        //Creating Employees
        public static Employee employee1 = new Employee("Elyssa Obeid", 26, "Fuel Pump", 632198, 700);
        public static Employee employee2 = new Employee("Ali Issa", 35, "Car Wash", 630138, 500);
        public static Employee employee3 = new Employee("Charbel Hajj", 20, "Truck Driver", 130158, 600);
        public static Employee employee4 = new Employee("Joe Masaad", 45, "Fuel Pump", 832178, 700);
        public static Employee employee5 = new Employee("Jean Eid", 56, "Tire Repair", 632198, 500);
        public static Employee employee6 = new Employee("Mhammad Emamo", 29, "Fuel Pump", 922138, 700);

        //Creating Fuel Tanks
        public static FuelTank Tank1 = new FuelTank(56000, 1);
        public static FuelTank Tank2 = new FuelTank(23000, 2);
        public static FuelTank Tank3 = new FuelTank(17000, 3);
        public static FuelTank Tank4 = new FuelTank(32000, 4);

        public static List<FuelTank> FuelTanks = new List<FuelTank>();
        
        


        //Creating Fuel Pumps
        public static FuelPump fuelpump1 = new FuelPump(1, 1124);
        public static FuelPump fuelpump2 = new FuelPump(2, 7652);
        public static FuelPump fuelpump3 = new FuelPump(3, 4406);
        public static FuelPump fuelpump4 = new FuelPump(4, 3281);




        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the software?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            ClientsForm clientsform = new ClientsForm();
            clientsform.Show();
            this.Hide();
            
        }

        private void FuelPumpsCountersButton_Click(object sender, EventArgs e)
        {
            FuelPumpsForm fuelpumps = new FuelPumpsForm();
            fuelpumps.Show();
            this.Hide();


        }

        private void FuelTanksButton_Click(object sender, EventArgs e)
        {
            FuelTanksForm fueltanks = new FuelTanksForm();
            fueltanks.Show();
            this.Hide();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesform = new EmployeesForm();
            employeesform.Show();
            this.Hide();
        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            IncomeForm incomeform = new IncomeForm();
            incomeform.Show();
            this.Hide();
        }
    }
}

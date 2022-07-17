using FuelTankNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharbelTabet_OOD_Project2.Forms
{
    public partial class FuelTanksForm : Form
    {
        public FuelTanksForm()
        {
            InitializeComponent();
        }

        private void GoBackTankButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void FuelTanksForm_Load(object sender, EventArgs e)
        {
            UpdateTanks();

        }

        // Add of Tank 1
        private void Addbutton1_Click(object sender, EventArgs e)
        {
            if (Tank1TextBox.Text != "")
            {
                int amount = int.Parse(Tank1TextBox.Text);
                MainForm.Tank1.AddToTank(amount);
                UpdateTanks();
                Tank1TextBox.Clear();


            }
            else
                MessageBox.Show("Input a number!");

        }

        // Add of Tank 2
        private void Addbutton2_Click(object sender, EventArgs e)
        {
            if (Tank2TextBox.Text != "")
            {
                int amount = int.Parse(Tank2TextBox.Text);
                MainForm.Tank2.AddToTank(amount);
                UpdateTanks();
                Tank2TextBox.Clear();


            }
            else
                MessageBox.Show("Input a number!");
        }

        //Add of Tank 3
        private void Addbutton3_Click(object sender, EventArgs e)
        {
            if (Tank3TextBox.Text != "")
            {
                int amount = int.Parse(Tank3TextBox.Text);
                MainForm.Tank3.AddToTank(amount);
                UpdateTanks();
                Tank3TextBox.Clear();


            }
            else
                MessageBox.Show("Input a number!");
        }

        // Add of Tank 4
        private void Addbutton4_Click(object sender, EventArgs e)
        {
            if (Tank4TextBox.Text != "")
            {
                int amount = int.Parse(Tank4TextBox.Text);
                MainForm.Tank4.AddToTank(amount);
                UpdateTanks();
                Tank4TextBox.Clear();


            }
            else
                MessageBox.Show("Input a number!");
        }

        // Remove of Tank 1
        private void Removebutton1_Click(object sender, EventArgs e)
        {
            if (Tank1TextBox.Text != "")
            {
                int amount = int.Parse(Tank1TextBox.Text);
                MainForm.Tank1.RemoveFromTank(amount);
                if(MainForm.Tank1.AvailableQuantity < 0)
                 MainForm.Tank1.AvailableQuantity = 0; 
                UpdateTanks();
                Tank1TextBox.Clear();


            }
            else
                MessageBox.Show("Input a number!");

        }

        // Remove of Tank 2
        private void Removebutton2_Click(object sender, EventArgs e)
        {
            if (Tank2TextBox.Text != "")
            {
                int amount = int.Parse(Tank2TextBox.Text);
                MainForm.Tank2.RemoveFromTank(amount);
                if (MainForm.Tank2.AvailableQuantity < 0)
                    MainForm.Tank2.AvailableQuantity = 0;
                UpdateTanks();
                Tank2TextBox.Clear();


            }
            else
                MessageBox.Show("Input a number!");

        }

        // Remove of Tank 3
        private void Removebutton3_Click(object sender, EventArgs e)
        {
            if (Tank3TextBox.Text != "")
            {
                int amount = int.Parse(Tank3TextBox.Text);
                MainForm.Tank3.RemoveFromTank(amount);
                if (MainForm.Tank3.AvailableQuantity < 0)
                    MainForm.Tank3.AvailableQuantity = 0;
                UpdateTanks();
                Tank3TextBox.Clear();


            }
            else
                MessageBox.Show("Input a number!");
        }

        // Remove of Tank 4
        private void Removebutton4_Click(object sender, EventArgs e)
        {
            if (Tank4TextBox.Text != "")
            {
                int amount = int.Parse(Tank4TextBox.Text);
                MainForm.Tank4.RemoveFromTank(amount);
                if (MainForm.Tank4.AvailableQuantity < 0)
                    MainForm.Tank4.AvailableQuantity = 0;
                UpdateTanks();
                Tank4TextBox.Clear();


            }
            else
                MessageBox.Show("Input a number!");
        }












        public void UpdateTanks()
        {
            Q1Label.Text = $"{MainForm.Tank1.AvailableQuantity} Liters";
            Q2Label.Text = $"{MainForm.Tank2.AvailableQuantity} Liters";
            Q3Label.Text = $"{MainForm.Tank3.AvailableQuantity} Liters";
            Q4Label.Text = $"{MainForm.Tank4.AvailableQuantity} Liters";
        }

       
    }
}

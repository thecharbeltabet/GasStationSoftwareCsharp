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
    public partial class FuelPumpsForm : Form
    {
        public FuelPumpsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void FuelPumpsForm_Load(object sender, EventArgs e)
        {
            F1Label1.Text = $"{MainForm.fuelpump1.PreviousFuelPumpCounter}";
            F2Label1.Text = $"{MainForm.fuelpump2.PreviousFuelPumpCounter}";
            F3Label1.Text = $"{MainForm.fuelpump3.PreviousFuelPumpCounter}";
            F4Label1.Text = $"{MainForm.fuelpump4.PreviousFuelPumpCounter}";
        }

        private void CalculateLSButton_Click(object sender, EventArgs e)
        {
            if (F1TextBox2.Text != "")
            {
                int amount1 = int.Parse(F1TextBox2.Text);
                MainForm.fuelpump1.CalculateLitersSold(MainForm.fuelpump1.PreviousFuelPumpCounter, amount1);
                LS1.Text = $"{MainForm.fuelpump1.LitersSold}L";
            }
            else
                MessageBox.Show("You cannot leave a new counter empty!","Counter 1");


            if (F2TextBox2.Text != "")
            {
                int amount2 = int.Parse(F2TextBox2.Text);
                MainForm.fuelpump2.CalculateLitersSold(MainForm.fuelpump2.PreviousFuelPumpCounter, amount2);
                LS2.Text = $"{MainForm.fuelpump2.LitersSold}L";
            }
            else
                MessageBox.Show("You cannot leave a new counter empty!","Counter 2");


            if (F3TextBox2.Text != "")
            {
                int amount3 = int.Parse(F3TextBox2.Text);
                MainForm.fuelpump3.CalculateLitersSold(MainForm.fuelpump3.PreviousFuelPumpCounter, amount3);
                LS3.Text = $"{MainForm.fuelpump3.LitersSold}L";
            }
            else
                MessageBox.Show("You cannot leave a new counter empty!", "Counter 3");

            if (F4TextBox2.Text != "")
            {
                int amount4 = int.Parse(F4TextBox2.Text);
                MainForm.fuelpump4.CalculateLitersSold(MainForm.fuelpump4.PreviousFuelPumpCounter, amount4);
                LS4.Text = $"{MainForm.fuelpump4.LitersSold}L";
            }
            else
                MessageBox.Show("You cannot leave a new counter empty!","Counter 4");
        }

        public void CalculateTotal()
        {
            if (LS1.Text != "NA" && LS2.Text != "NA" && LS3.Text != "NA" && LS4.Text != "NA")
            {
                if (PriceTextBox.Text != "")
                {
                    int price = int.Parse(PriceTextBox.Text);
                    int Total;
                    Total = ((MainForm.fuelpump1.LitersSold) + (MainForm.fuelpump2.LitersSold) + (MainForm.fuelpump3.LitersSold) + (MainForm.fuelpump4.LitersSold)) * price;
                    labeltotal.Text = $"{Total}$";
                }
                else
                    MessageBox.Show("Don't Forget to enter a price");
                UpdatePreviousCounters();
            }
            
            else
                MessageBox.Show("You should calculate the Liters sold before the Total");
            
        }

        public void UpdatePreviousCounters()
        {
            int l1 = int.Parse(F1TextBox2.Text);
            MainForm.fuelpump1.PreviousFuelPumpCounter = l1;
            int l2 = int.Parse(F2TextBox2.Text);
            MainForm.fuelpump2.PreviousFuelPumpCounter = l2;
            int l3 = int.Parse(F3TextBox2.Text);
            MainForm.fuelpump3.PreviousFuelPumpCounter = l3;
            int l4 = int.Parse(F4TextBox2.Text);
            MainForm.fuelpump4.PreviousFuelPumpCounter = l4;
        }

        private void CalculateTotalButton_Click(object sender, EventArgs e)
        {
            CalculateTotal();
           
        }
    }
}

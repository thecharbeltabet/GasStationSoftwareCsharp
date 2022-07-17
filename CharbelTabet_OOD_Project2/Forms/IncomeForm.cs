using CharbelTabet_OOD_Project2.Classes;
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
    public partial class IncomeForm : Form
    {

        static Income income = new Income();
        PureIncome pureincome = new PureIncome();
        IncomeWExpenses incomewexpenses = new IncomeWExpenses();
        IncomeWTaxes incometaxes = new IncomeWTaxes();


        public IncomeForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
           
            if (SalestextBox.Text != "")
            {
                int amount = int.Parse(SalestextBox.Text);


                if (IncomePureButton.Checked == true)
                {
                    income.SetIncomeStrategy(pureincome);

                }
                

                if (IncomewTaxesButton.Checked == true)
                {
                    income.SetIncomeStrategy(incometaxes);
                }
                

                if (IncomewExpensesButton.Checked == true)
                {
                    income.SetIncomeStrategy(incomewexpenses);
                }

                TotalIncomeLabel.Text = $"{income.CalculateIncome(amount)}$";
            }
            else
                MessageBox.Show("Please enter the sales amount and select a strategy!");

            


        }

        private void GobackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}

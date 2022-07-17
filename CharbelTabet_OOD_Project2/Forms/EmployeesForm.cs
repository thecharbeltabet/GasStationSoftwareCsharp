using EmployeeNS;
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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            EmployeesListBox.Items.Add(MainForm.employee1.FullName);
            EmployeesListBox.Items.Add(MainForm.employee2.FullName);
            EmployeesListBox.Items.Add(MainForm.employee3.FullName);
            EmployeesListBox.Items.Add(MainForm.employee4.FullName);
            EmployeesListBox.Items.Add(MainForm.employee5.FullName);
            EmployeesListBox.Items.Add(MainForm.employee6.FullName);


        }

        private void EmployeesListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (EmployeesListBox.SelectedIndex == 0)
                FillEmployeesInfo(MainForm.employee1);
            else if (EmployeesListBox.SelectedIndex == 1)
                FillEmployeesInfo(MainForm.employee2);
            else if (EmployeesListBox.SelectedIndex == 2)
                FillEmployeesInfo(MainForm.employee3);
            else if (EmployeesListBox.SelectedIndex == 3)
                FillEmployeesInfo(MainForm.employee4);
            else if (EmployeesListBox.SelectedIndex == 4)
                FillEmployeesInfo(MainForm.employee5);
            else if (EmployeesListBox.SelectedIndex == 5)
                FillEmployeesInfo(MainForm.employee6);

        }

        public void FillEmployeesInfo(Employee employee)
        {
            FullNameLabelFill.Text = $"{employee.FullName}";
            EmpAgeFillLabel.Text = $"{employee.Age}";
            TypeLabelFill.Text = $"{employee.TypeOfEmployee }";
            SSNFillLabel.Text = $"{employee.SocialSecurityNumber}";
            SalaryLabelFill.Text = $"{employee.SalaryOfEmployee}$";
        }

        private void BonusButton_Click(object sender, EventArgs e)
        {
            if (InputTextbox.Text != "" && SalaryLabelFill.Text != "NA")
            {
                int amount = int.Parse(InputTextbox.Text);
                if (EmployeesListBox.SelectedIndex == 0)
                {
                    MainForm.employee1.AddAmount(amount);
                    FillEmployeesInfo(MainForm.employee1);

                }
                else if (EmployeesListBox.SelectedIndex == 1)
                {
                    MainForm.employee2.AddAmount(amount);
                    FillEmployeesInfo(MainForm.employee2);


                }

                else if (EmployeesListBox.SelectedIndex == 2)
                {
                    MainForm.employee3.AddAmount(amount);
                    FillEmployeesInfo(MainForm.employee3);
                }
                else if (EmployeesListBox.SelectedIndex == 3)
                {
                    MainForm.employee4.AddAmount(amount);
                    FillEmployeesInfo(MainForm.employee4);
                }
                else if (EmployeesListBox.SelectedIndex == 4)
                {
                    MainForm.employee5.AddAmount(amount);
                    FillEmployeesInfo(MainForm.employee5);
                }

                else if (EmployeesListBox.SelectedIndex == 5)
                {
                    MainForm.employee6.AddAmount(amount);
                    FillEmployeesInfo(MainForm.employee6);

                }
                InputTextbox.Clear();
            }
            else
                MessageBox.Show("You should choose a client and input a number");
        }

        private void DeductButton_Click(object sender, EventArgs e)
        {
            if (InputTextbox.Text != "" && SalaryLabelFill.Text != "NA")
            {
                int amount2 = int.Parse(InputTextbox.Text);

                if (EmployeesListBox.SelectedIndex == 0)
                {
                    MainForm.employee1.DeductAmount(amount2);
                    FillEmployeesInfo(MainForm.employee1);

                }
                else if (EmployeesListBox.SelectedIndex == 1)
                {
                    MainForm.employee2.DeductAmount(amount2);
                    FillEmployeesInfo(MainForm.employee2);


                }

                else if (EmployeesListBox.SelectedIndex == 2)
                {
                    MainForm.employee3.DeductAmount(amount2);
                    FillEmployeesInfo(MainForm.employee3);
                }
                else if (EmployeesListBox.SelectedIndex == 3)
                {
                    MainForm.employee4.DeductAmount(amount2);
                    FillEmployeesInfo(MainForm.employee4);
                }
                else if (EmployeesListBox.SelectedIndex == 4)
                {
                    MainForm.employee5.DeductAmount(amount2);
                    FillEmployeesInfo(MainForm.employee5);
                }

                else if (EmployeesListBox.SelectedIndex == 5)
                {
                    MainForm.employee6.DeductAmount(amount2);
                    FillEmployeesInfo(MainForm.employee6);

                }
                InputTextbox.Clear();
            }
            else
                MessageBox.Show("You should choose a client and input a number");
        }
    }
}

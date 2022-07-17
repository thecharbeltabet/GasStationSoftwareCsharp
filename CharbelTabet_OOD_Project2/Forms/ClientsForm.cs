
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientsNS;
using CharbelTabet_OOD_Project2.Forms;
using ManagerNS;



namespace CharbelTabet_OOD_Project2.Forms
{
    public partial class ClientsForm : Form
    {
       

        public ClientsForm()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();

        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
          ClientsListBox.Items.Add(MainForm.client1.FullName);
          ClientsListBox.Items.Add(MainForm.client2.FullName);
          ClientsListBox.Items.Add(MainForm.client3.FullName);
          ClientsListBox.Items.Add(MainForm.client4.FullName);
          ClientsListBox.Items.Add(MainForm.client5.FullName);
          ClientsListBox.Items.Add(MainForm.client6.FullName);

        }

        public void FillClientsInfo(Client client)
        {
            FullNameLabelFill.Text = $"{client.FullName}";
            agelabelfill.Text = $"{client.Age}";
            RegNumLabelfill.Text = $"{client.RegistrationNumber }";
            CarLabelFill.Text = $"{client.CarOfClient}";
            BalanceLabelFill.Text = $"{client.BalanceOfClient}$";
        }

        private void ClientsListBox_Click(object sender, EventArgs e)
        {
            if (ClientsListBox.SelectedIndex == 0)
                FillClientsInfo(MainForm.client1);
            else if (ClientsListBox.SelectedIndex == 1)
                FillClientsInfo(MainForm.client2);
            else if (ClientsListBox.SelectedIndex == 2)
                FillClientsInfo(MainForm.client3);
            else if (ClientsListBox.SelectedIndex == 3)
                FillClientsInfo(MainForm.client4);
            else if (ClientsListBox.SelectedIndex == 4)
                FillClientsInfo(MainForm.client5);
            else if (ClientsListBox.SelectedIndex == 5)
                FillClientsInfo(MainForm.client6);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (InputTextbox.Text != "" && BalanceLabelFill.Text != "NA")
            {
                int amount = int.Parse(InputTextbox.Text);
                if (ClientsListBox.SelectedIndex == 0)
                {
                    MainForm.client1.AddAmount(amount);
                    FillClientsInfo(MainForm.client1);

                }
                else if (ClientsListBox.SelectedIndex == 1)
                {
                    MainForm.client2.AddAmount(amount);
                    FillClientsInfo(MainForm.client2);


                }

                else if (ClientsListBox.SelectedIndex == 2)
                {
                    MainForm.client3.AddAmount(amount);
                    FillClientsInfo(MainForm.client3);
                }
                else if (ClientsListBox.SelectedIndex == 3)
                {
                    MainForm.client4.AddAmount(amount);
                    FillClientsInfo(MainForm.client4);
                }
                else if (ClientsListBox.SelectedIndex == 4)
                {
                    MainForm.client5.AddAmount(amount);
                    FillClientsInfo(MainForm.client5);
                }

                else if (ClientsListBox.SelectedIndex == 5)
                {
                    MainForm.client6.AddAmount(amount);
                    FillClientsInfo(MainForm.client6);

                }
                InputTextbox.Clear();
            }
            else
                MessageBox.Show("You should choose a client and input a number");




        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            if (InputTextbox.Text != "" && BalanceLabelFill.Text != "NA")
            {
                int amount2 = int.Parse(InputTextbox.Text);

                if (ClientsListBox.SelectedIndex == 0)
                {
                    MainForm.client1.DeductAmount(amount2);
                    FillClientsInfo(MainForm.client1);

                }
                else if (ClientsListBox.SelectedIndex == 1)
                {
                    MainForm.client2.DeductAmount(amount2);
                    FillClientsInfo(MainForm.client2);


                }

                else if (ClientsListBox.SelectedIndex == 2)
                {
                    MainForm.client3.DeductAmount(amount2);
                    FillClientsInfo(MainForm.client3);
                }
                else if (ClientsListBox.SelectedIndex == 3)
                {
                    MainForm.client4.DeductAmount(amount2);
                    FillClientsInfo(MainForm.client4);
                }
                else if (ClientsListBox.SelectedIndex == 4)
                {
                    MainForm.client5.DeductAmount(amount2);
                    FillClientsInfo(MainForm.client5);
                }

                else if (ClientsListBox.SelectedIndex == 5)
                {
                    MainForm.client6.DeductAmount(amount2);
                    FillClientsInfo(MainForm.client6);

                }
                InputTextbox.Clear();
            }
            else
                MessageBox.Show("You should choose a client and input a number");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            if (ClientsListBox.SelectedIndex != -1)

            
            {

                int amountFilled = int.Parse(AmountFilledTextBox.Text);
                int TankFilledFrom = int.Parse(TankFilledTextbox.Text);
                int LitersFilled = int.Parse(LitersFilledTextBox.Text);

                if (TankFilledFrom > 0 && TankFilledFrom <= 4)
                {
                    Manager.GetInstance().ClientFill(amountFilled, LitersFilled, TankFilledFrom, MainForm.ClientsList[ClientsListBox.SelectedIndex]);
                    FillClientsInfo(MainForm.ClientsList[ClientsListBox.SelectedIndex]);
                }
                else
                    MessageBox.Show("Choose a tank from 1 to 4");
            }
            else
                MessageBox.Show("Choose a client first!");

                AmountFilledTextBox.Clear();
                TankFilledTextbox.Clear();
                LitersFilledTextBox.Clear();
            



        }
    }




}

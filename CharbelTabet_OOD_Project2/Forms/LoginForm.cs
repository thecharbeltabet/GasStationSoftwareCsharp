using CharbelTabet_OOD_Project2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharbelTabet_OOD_Project2
{

    public partial class LoginForm : Form
    {
        public static string Username = "admin";
        public static string password = "admin";

        public LoginForm()
        {
            InitializeComponent();
        }

        public void Login()
        {
            if (UsernameEntry.Text == Username && PasswordEntry.Text == password  )
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else if (UsernameEntry.Text == "" || PasswordEntry.Text == "")
            {
                MessageBox.Show("You cannot leave an empty field");

            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
                UsernameEntry.Clear();
                PasswordEntry.Clear();

               
            }



        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login();

        }

        private void LoginCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordEntry.PasswordChar = LoginCheckBox.Checked ? '\0' : '*';
        }

        private void ChangecredButton_Click(object sender, EventArgs e)
        {
            ChangeCredentialsForm credantialsform = new ChangeCredentialsForm();
            credantialsform.ShowDialog();
            
        }
    }
}

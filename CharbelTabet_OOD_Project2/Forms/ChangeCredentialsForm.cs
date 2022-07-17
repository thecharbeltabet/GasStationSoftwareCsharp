using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CharbelTabet_OOD_Project2.Forms
{
    public partial class ChangeCredentialsForm : Form
    {
        public ChangeCredentialsForm()
        {
            InitializeComponent();
        }


        public void ChangeCredentials()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox1.Text == LoginForm.password)
                {
                   
                    
                        if (textBox2.Text == textBox3.Text)
                            LoginForm.password = textBox2.Text;
                        else
                            MessageBox.Show("The password don't match");
                    
                    
                }
                else
                    MessageBox.Show("Your password is incorrect");

            }
            else
                MessageBox.Show("Dont leave any empty fields");


}

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeCredentials();
            this.Hide();
        }
    }
}

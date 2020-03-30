using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProiectPAW_Tuca_Madalin_1048
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {

          
            string fName = tbFirstName.Text;
                string lName = tbLastName.Text;
                string phone = tbPhone.Text;
                string email = tbEmail.Text;
                string pass = tbPass.Text;
                string confPass = tbConfPass.Text;
                string uName = tbAge.Text;
            if (tbFirstName.Text == "" || tbLastName.Text == "" || tbPhone.Text == "" || tbEmail.Text == "" || tbAge.Text == "" || tbPass.Text == "" || tbConfPass.Text == "")
            {
                MessageBox.Show("One or more fields ar empty!");

            }
            else
            {
                User u = new User(fName, lName, email, pass, confPass, phone, uName);
                MessageBox.Show(u.ToString());
            }
           // User u = new User(fName, lName, email, phone, age);
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            home h1 = new home();
            h1.Show();
            this.Visible = false;
            

        }

        private void tbConfPass_Validating(object sender, CancelEventArgs e)
        {
            if(tbPass.Text != tbConfPass.Text)
            {
                error.SetError(tbConfPass, "Passwords not matching!");
                tbConfPass.Focus();
            }else if(tbConfPass.Text == "")
            {
                error.SetError(tbConfPass, "You must confirm the password!");
            }
            else
            {
                error.SetError(tbConfPass, "");
            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (tbFirstName.Text == "")
            {
                error.SetError(tbFirstName, "Firstname input is empty!");
                tbFirstName.Focus();
            }
            else if (!Regex.IsMatch(tbFirstName.Text, "([A-ZAÎ??Â])+(?=.{1,40}$)[a-zA-ZAÎ??Âaî??]+(?:[-\\s][a-zA-ZAÎ??Âaî??â]+)*$"))
            {
                error.SetError(tbFirstName, "Name starts with a capital letter and no numbers!");
                tbFirstName.Focus();
            }
            else
            {
                error.SetError(tbFirstName, "");
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (tbLastName.Text == "")
            {
                error.SetError(tbLastName, "Lastname input is empty!");
                tbLastName.Focus();
            }
            else if (!Regex.IsMatch(tbLastName.Text, "([A-ZAÎ??Â])+(?=.{1,40}$)[a-zA-ZAÎ??Âaî??]+(?:[-\\s][a-zA-ZAÎ??Âaî??â]+)*$"))
            {
                error.SetError(tbLastName, "Name starts with a capital letter and no numbers!");
                tbLastName.Focus();
            }
            else
            {
                error.SetError(tbLastName, "");
            }
        }

      

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (tbPhone.Text == "")
            {
                error.SetError(tbPhone, "Phone input is empty!");
                tbPhone.Focus();
            }
            else if (!Regex.IsMatch(tbPhone.Text, @"^(\+4|)?(07[0-8]{1}[0-9]{1}|02[0-9]{2}|03[0-9]{2}){1}?(\s|\.|\-)?([0-9]{3}(\s|\.|\-|)){2}$"))
            {
                error.SetError(tbPhone, "Phone must respect the valid format!");
                tbPhone.Focus();
            }
            else
            {
                error.SetError(tbPhone, "");
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text == "")
            {
                error.SetError(tbEmail, "Phone input is empty!");
                tbEmail.Focus();
            }
            else if (!Regex.IsMatch(tbEmail.Text, @"[a-zA-Z0-9_\.-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9\.]{2,5}$"))
            {
                error.SetError(tbEmail, "Email must respect the valid format!");
                tbEmail.Focus();
            }
            else
            {
                error.SetError(tbEmail, "");
            }
        }

      

        private void tbPass_Validating(object sender, CancelEventArgs e)
        {
            if(tbPass.Text == "")
            {
                error.SetError(tbPass, "You must input your password!");
                tbPass.Focus();
            }
            else
            {
                error.SetError(tbPass, "");
            }
        }

       
       
    }
}

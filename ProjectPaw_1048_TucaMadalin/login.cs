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
using System.IO;

namespace ProiectPAW_Tuca_Madalin_1048
{
    public partial class login : UserControl

    {
         List<User> UserList1 = new List<User>();
        public static User u = new User();
        
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
                UserList1.Add(new User(fName, lName, email, phone, pass, confPass, uName));
                foreach (var user in UserList1)
                {
                    MessageBox.Show(user.ToString() + "\n");
                }
            }
            try
            {
                u.Nume = fName;
                u.Prenume = lName;
                u.NrTel = phone;
                u.Email = email;
                u.Pass = pass;
                u.ConfPass = confPass;
                u.UName = uName;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            // string docPath = @"C:\c#\users.txt";
            // File.WriteAllLines(docPath, new string[]{ uName, pass});
            TextWriter userWrite = new StreamWriter("LoginInfo.txt");
            foreach(User s in UserList1)
            {
                userWrite.WriteLine(s.UName);
                userWrite.WriteLine(s.ConfPass);
            }
            userWrite.Close();
            TextWriter tw = new StreamWriter("UserList.txt");
            foreach(var u in UserList1)
            {
                tw.WriteLine(u);
            }
            tw.Close();

      
        }


      public string getUName()
        {
            return tbAge.Text;
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

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            tbPass.UseSystemPasswordChar = true;
        }

        private void tbConfPass_TextChanged(object sender, EventArgs e)
        {
            tbConfPass.UseSystemPasswordChar = true;
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode.ToString() == "L")
            {

                button4_Click(sender, e);
            }
        }

        private void tbAge_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode.ToString() == "R")
            {
                button4_Click(sender, e);
            }
        }
    }
}

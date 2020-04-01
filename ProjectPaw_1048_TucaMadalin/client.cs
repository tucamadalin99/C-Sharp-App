using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectPAW_Tuca_Madalin_1048;
using System.IO;

namespace ProjectPaw_1048_TucaMadalin
{
    public partial class client : UserControl
    {

        
        User newU = new User();
        
        //List<User> calledList = login.GetList();
       
       
        public client()
        {
            InitializeComponent();
           
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tbPassLog.UseSystemPasswordChar = true;
        }

        private void logBtn_Click(object sender, EventArgs e)
        {

            //tbuName.Text.CompareTo(
            
           
            var log = new login();
            string username = log.getUName();
            string path = Directory.GetCurrentDirectory()+ @"\LoginInfo.txt"; 
            string[] compUser = File.ReadAllLines(path);


            if (compUser[0] == tbuName.Text && compUser[1] == tbPassLog.Text && tbuName.Text != "" && tbPassLog.Text != "")
            {

                MessageBox.Show("Welcome, " + tbuName.Text +"!");
                Form2 form2 = new Form2();
                form2.Show();
                //Closing first form
                ((Form)this.TopLevelControl).Close();
                //////////
                ///
            }else if((tbuName.Text == "" && tbPassLog.Text == ""))
            {
                MessageBox.Show("Input your username and password!");
            }
            else { MessageBox.Show("Invalid user or password! Try Again!"); }
           

        }
    }
}

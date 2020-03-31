using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_Tuca_Madalin_1048
{
    public partial class Form2 : Form
    {

        private readonly firstPanel _form1;
        public Form2(firstPanel form1)
        {
            _form1 = form1;
        }

       
        public Form2()
        {
            string path = @"C:\c#\users.txt";
            string[] user = File.ReadAllLines(path);
            InitializeComponent();
            labelName.Text += user[0];
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            firstPanel f1 = new firstPanel();
            this.Visible = false;
            f1.ShowDialog();
        }

        private void accBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

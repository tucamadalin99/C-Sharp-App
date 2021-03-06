﻿using ProjectPaw_1048_TucaMadalin;
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
            InitializeComponent();
            rtb1.Visible = false;
            hotels2.Visible = false;
            admin1.Visible = false;
 
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        int checkAdmin = 0;
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            firstPanel f1 = new firstPanel();
            this.Visible = false;
            checkAdmin = 0;
            f1.ShowDialog();
        }

        private void accBtn_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("UserList.txt");
            hotels2.Visible = false;
            rtb1.Visible = true;
            admin1.Hide();
            checkAdmin = 0;
            rtb1.Text = sr.ReadToEnd();


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            hotels2.Visible = true;
            rtb1.Visible = false;
            checkAdmin = 0;
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            if (checkAdmin == 1 && admin1.Visible == false)
            {
                this.Hide();
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login as admin first!");
            }
        }

        private void bookedBtn_Click(object sender, EventArgs e)
        {
            hotels2.Visible = false;
            Form4 f4 = new Form4();
            f4.ShowDialog();
            

        }

        private void checkAdBtn_Click(object sender, EventArgs e)
        {
            admin1.Visible = true;
            checkAdmin = 1;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }
    }
}

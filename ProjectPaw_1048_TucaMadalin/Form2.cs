using ProjectPaw_1048_TucaMadalin;
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
            hotels1.Visible = false;
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
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
            StreamReader sr = new StreamReader("UserList.txt");
            hotels1.Visible = false;
            rtb1.Visible = true;
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
            hotels1.Visible = true;
            rtb1.Visible = false;
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }
    }
}

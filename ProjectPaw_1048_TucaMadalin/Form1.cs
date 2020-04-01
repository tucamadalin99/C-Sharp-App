using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_Tuca_Madalin_1048
{
    public partial class firstPanel : Form
    {

       List<User> UserList = new List<User>();
        public firstPanel()
        {
            InitializeComponent();
            
            home1.Visible = true;
            login1.Visible = false;
        
        }
       
        private void firstPanel_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;
       

        public object UserLogin1 { get; private set; }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          //  this.BackColor = Color.DarkSlateBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            home1.Visible = false;
            login1.Visible = true;
            
           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            home1.Visible = true;
            login1.Visible = false;
            
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            login1.Visible = true;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            home1.Visible = true;
            login1.Visible = false;
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            login1.Visible = false;
        }


        private void timeLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


//home1.Visible = false;
         //   login1.Visible = true;
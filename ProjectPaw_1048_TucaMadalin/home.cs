using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_Tuca_Madalin_1048
{
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();
            timer1.Start();
            
        }


        private void timeLbl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.timeLbl.Text = dateTime.ToString();
        }
    }
}

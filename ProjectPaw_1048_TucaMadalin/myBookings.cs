using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProjectPaw_1048_TucaMadalin;

namespace ProjectPaw_1048_TucaMadalin
{
    public partial class myBookings : UserControl
    {
        
        int count = 0;
        public myBookings()
        {
            InitializeComponent();

        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            
            
            count++;
            var lines = File.ReadAllLines("BookedHotels.txt");
            if (lines.Length == 0)
            {
                MessageBox.Show("Nothing Booked yet!");
            }
            else
            {
                
                for (int i = 0; i < lines.Length; i += 7)
                {
                    var item = new ListViewItem(new string[]
                    {
                        (count).ToString(),
                        lines[i],
                        lines[i+1],
                        lines[i+2],
                        lines[i+3],
                        lines[i+5]
                        

                    });
                    listView1.Items.Add(item);
                    listView1.ForeColor = System.Drawing.Color.White;
                }
            }
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}

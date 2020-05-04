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
using ProiectPAW_Tuca_Madalin_1048;
using ProjectPaw_1048_TucaMadalin;

namespace ProjectPaw_1048_TucaMadalin
{
    public partial class Form4 : Form
    {
        int count = 0;
        hotels h1 = new hotels();

        public Form4()
        {
            InitializeComponent();
            
         
        }

        public void displayInList2()
        {
            

            foreach (var c in Cazari)
            {
                var item = new ListViewItem(new string[]
                {
                (c.Id - 39).ToString(),
                c.Denumire,
                c.Locatie,
                c.NrZile.ToString(),
                c.NrCamera.ToString(),
                c.PretMediu.ToString()
                });
                item.ForeColor = System.Drawing.Color.Black;
                item.Tag = c;

                listView1.Items.Add(item);
            }

        }

        public List<Cazare> cazari = new List<Cazare>();
      
        public List<Cazare> Cazari
        {
            set { cazari = value; }
            get { return cazari; }
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
                    listView1.ForeColor = System.Drawing.Color.Black;
                }
            }

        }
    }
}

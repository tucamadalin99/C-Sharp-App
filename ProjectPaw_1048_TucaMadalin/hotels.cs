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
    public partial class hotels : UserControl
    {
        List<Cazare> cazariLista = new List<Cazare>();
        
        
        public hotels()
        {
            InitializeComponent();

        }

        private void client1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void genTxtBtn_Click(object sender, EventArgs e)
        {
           
            double[] preturi = { 345.65, 341.32, 214.53, 321.43 };
            Cazare c1 = new Cazare("Constinesti", 4, "Casa Duca", 4, "Dubla", preturi, 0);
            Cazare c2 = new Cazare("Bucuresti", 4, "InterContinental", 4, "Single", preturi, 0);
            Cazare c3 = new Cazare("Targu Jiu", 4, "Europa", 5, "Single", preturi, 0);
            Cazare c4 = new Cazare("Bucuresti", 4, "Continental", 5, "Dubla", preturi, 0);
            Cazare c5 = new Cazare("Bucuresti", 4, "Azure", 5, "Single", preturi, 0);
            Cazare c6 = new Cazare("Bucuresti", 4, "Linux", 5, "Single", preturi, 0);
            Cazare[] cazari = {c1,c2,c3,c4,c5,c6};

            //cazariLista.Add(new Cazare("Bucuresti", 4, "Capital3", 5, "Single", preturi, 0));



            for (int counter = 0; counter < 6; counter++)
            {
                cazariLista.Add(cazari[counter]);
            }

            StreamWriter sr = new StreamWriter("HotelTxtReport.txt");   

            
            foreach(var hotel in cazariLista)
            {
                sr.WriteLine(hotel + "\n-------------------------------------\n");
            }
            sr.Close();
            MessageBox.Show("Text report generated in bin/Debug!");

            StreamReader st = new StreamReader("HotelTxtReport.txt");
            List<ListView> listOfLists = new List<ListView>();
            listOfLists.Add(listView1);
            listOfLists.Add(listView2);
            listOfLists.Add(listView3);
            listOfLists.Add(listView4);
            listOfLists.Add(listView5);
            listOfLists.Add(listView6);
            int i = 0;
            foreach(var l in listOfLists)
            {
                
                    l.Items.Add("Name:" + cazari[i].Denumire);
                    l.Items.Add("Location: " + cazari[i].Locatie);
                    l.Items.Add("Days: " + cazari[i].NrZile.ToString());
                    l.Items.Add("Rooms: " +cazari[i].NrCamera.ToString());
                    l.Items.Add("Price: " + cazari[i].Preturi[0].ToString());
                   // l.Items.Add(cazari[i].PretMediu.ToString());

                i++;
            }

            st.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            listView3.Visible = false;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            listView4.Visible = false;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            listView5.Visible = false;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            listView6.Visible = false;
        }
        
    }
}

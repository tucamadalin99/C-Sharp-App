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
        private List<Cazare> cazariLista = new List<Cazare>();
        List<Cazare> cazariSelected = new List<Cazare>();



        Cazare[] cazari = new Cazare[10];

        internal List<Cazare> CazariLista { get => cazariLista; set => cazariLista = value; }

        public hotels()
        {

            // StreamWriter sw = new StreamWriter("Hoteluri.txt");
            InitializeComponent();
            cazari[0] = new Cazare("Vraja Marii", "Costinesti", 10, 20, "Dubla/Single", 300.5);
            cazari[1] = new Cazare("Continental", "Bucuresti", 5, 100, "Dubla/Single/Rezidentiala", 300.5);
            cazari[2] = new Cazare("Star", "Constanta", 10, 25, "Dubla/Single/Rezidentiala", 300.5);
            cazari[3] = new Cazare("Casa Duca", "Costinesti", 7, 20, "Dubla/Single", 300.5);
            cazari[4] = new Cazare("Apex", "Mamaia", 3, 20, "Dubla/Single/Rezidentiala", 300.5);
            cazari[5] = new Cazare("Lux", "Costinesti", 5, 30, "Dubla/Single", 300.5);
            cazari[6] = new Cazare("Stefan", "Costinesti", 6, 20, "Dubla/Single", 300.5);
            cazari[7] = new Cazare("Luxor", "Saturn", 3, 20, "Dubla/Single", 300.5);
            cazari[8] = new Cazare("Plaja", "Costinesti", 3, 25, "Dubla/Single/Rezidentiala", 300.5);
            cazari[9] = new Cazare("Polar", "Venus", 5, 40, "Single/Dubla/Rezidentiala", 300.5);

            for (int i = 1; i <= 9; i++)
            {
                cazari[i].Id = i;
            }

            for (int i = 0; i < 10; i++)
            {

                cazari[i].genPrice();
            }
            //  for(int i = 0; i < 10; i++)
            //  {
            //    sw.WriteLine(cazari[i]);
            //  }
            // sw.Close();
        }

        private void client1_Load(object sender, EventArgs e)
        {


        }

        private void genTxtBtn_Click(object sender, EventArgs e)
        {

        }

        private void LoadFromFile(string path)
        {
            CazariLista.Clear();
            try
            {
                var lines = File.ReadAllLines(path);

                for (int i = 0; i < lines.Length; i += 7)
                {
                    CazariLista.Add(new Cazare(
                        den: lines[i],
                        l: lines[i + 1],
                        nrZ: Int32.Parse(lines[i + 2]),
                        nrC: Int32.Parse(lines[i + 3]),
                        tipC: lines[i + 4],
                        pM: Double.Parse(lines[i + 5])
                        ));
                }

                foreach (var c in CazariLista)
                {
                    c.genPrice();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void displayInList()
        {
            listView1.Items.Clear();

            foreach (var c in CazariLista)
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
                item.ForeColor = System.Drawing.Color.White;
                item.Tag = c;

                listView1.Items.Add(item);
            }

        }


        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Fișiere text (*.txt)|*.txt|Toate fișierele (*.*)|*.*";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    LoadFromFile(dialog.FileName);
                    displayInList();
                }
            }
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("No selected items to delete from list!");
                return;

            }

            var c = (Cazare)listView1.SelectedItems[0].Tag;
            var rezultat = MessageBox.Show(this,
                $"Are you sure you want to delete '{c.Denumire}'?",
                "Delete item",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rezultat == DialogResult.Yes)
            {
                CazariLista.Remove(c);
                displayInList();
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            var item = listView1.SelectedItems;
            MessageBox.Show(item.ToString());
        }

        private void bookSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cazariSelected.Clear();

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("No selected items selected to book!");
                return;

            }

            Form4 f4 = new Form4();
            var c = (Cazare)listView1.SelectedItems[0].Tag;
            var rezultat = MessageBox.Show(this,
                $"Do you want to book: '{c.Denumire}'?",
                "Book selected",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rezultat == DialogResult.Yes)
            {
                var item = (Cazare)listView1.SelectedItems[0].Tag;
                cazariSelected.Add(item);
                StreamWriter sw = new StreamWriter("BookedHotels.txt");
                foreach (var caz in cazariSelected)
                {
                    sw.WriteLine(caz);
                }
                sw.Close();
            }

        }

    }
}

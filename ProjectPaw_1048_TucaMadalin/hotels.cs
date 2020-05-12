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
using System.Data.OleDb;


namespace ProjectPaw_1048_TucaMadalin
{
    public partial class hotels : UserControl
    {
        private List<Cazare> cazariLista = new List<Cazare>();
        List<Cazare> cazariSelected = new List<Cazare>();
        string connString;


        Cazare[] cazari = new Cazare[10];
        
        internal List<Cazare> CazariLista { get => cazariLista; set => cazariLista = value; }

        public hotels()
        {

            // StreamWriter sw = new StreamWriter("Hoteluri.txt");
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Cazari.accdb";
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

        private void LoadFromDb()
        {

            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
               
                CazariLista.Clear();
                conn.Open();
                OleDbCommand com = new OleDbCommand("SELECT * FROM Cazari");
                com.Connection = conn;
                OleDbDataReader read = com.ExecuteReader();

                while (read.Read())
                {
                    CazariLista.Add(new Cazare(
                                            den: read["Denumire"].ToString(),
                                            l: read["Locatie"].ToString(),
                                            nrZ: Int32.Parse(read["NrZile"].ToString()),
                                            nrC: Int32.Parse(read["NrCamere"].ToString()),
                                            tipC: read["TipCazare"].ToString(),
                                            pM: Double.Parse(read["PretMediu"].ToString())
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
            finally
            {
                conn.Close();
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

            
                    LoadFromDb();
                    displayInList();
            MessageBox.Show("Data from database loaded!");
            
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
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CazariEfectuate.accdb";
            OleDbConnection conex = new OleDbConnection(connStr);
            cazariSelected.Clear();
            try
            {
                conex.Open();
                OleDbCommand com = new OleDbCommand();
                com.Connection = conex;
                int id;
                var rezultat = MessageBox.Show(this,
               $"Do you want to book: '{listView1.SelectedItems[0].SubItems[1].Text}'?",
               "Book selected",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);
                if (rezultat == DialogResult.Yes)
                {

                    com.CommandText = "Select COUNT(*) from CazariEfectuate";
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        id = 0;
                    }
                    else { id = Convert.ToInt32(com.ExecuteScalar()); }

                    //com.CommandText = "SELECT (max)ID FROM CazariEfectuate";
                    //BUGS
                    
                    foreach (ListViewItem itm in listView1.SelectedItems)
                    {
                        com.CommandText = "INSERT into CazariEfectuate values(?,?,?,?,?,?,?)";
                        com.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                        com.Parameters.Add("Denumire", OleDbType.Char, 30).Value = itm.SubItems[1].Text;
                        com.Parameters.Add("Locatie", OleDbType.Char, 30).Value = itm.SubItems[2].Text;
                        com.Parameters.Add("NrZile", OleDbType.Integer).Value = Convert.ToInt32(itm.SubItems[3].Text);
                        com.Parameters.Add("NrCamere", OleDbType.Integer).Value = Convert.ToInt32(itm.SubItems[4].Text);
                        com.Parameters.Add("PretMediu", OleDbType.Double).Value = Convert.ToDouble(itm.SubItems[5].Text);
                        com.Parameters.Add("Locatie", OleDbType.Char, 30).Value = "Single";
                        com.ExecuteNonQuery();
                    }
                    conex.Close();

                }
                else
                {
                    throw new Exception("Nothing was booked!");
                }
               
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("No selected items selected to book!");
                    return;

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

      
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listView1.Items.Count > 0)
                try { listView1.DoDragDrop(listView1.SelectedItems, DragDropEffects.Copy | DragDropEffects.Move); }
                catch (Exception ex)
                {
                    MessageBox.Show("No string selected!");
                }
        }

        private void genTxtBtn_DragDrop(object sender, DragEventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }

        private void genTxtBtn_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }

        private void hotels_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
           
            listView1.SelectedItems[0].Remove();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }
    }
}

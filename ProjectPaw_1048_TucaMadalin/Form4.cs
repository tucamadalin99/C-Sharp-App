using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPaw_1048_TucaMadalin
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            confPnl.Visible = false;
            
            }
        double sum = 0.0;
        private void selectBtn_Click(object sender, EventArgs e)
        {
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CazariEfectuate.accdb";
            OleDbConnection conex = new OleDbConnection(connStr);
            try {
                listView1.Items.Clear();
                conex.Open();
                OleDbCommand com = new OleDbCommand("SELECT * FROM cazariEfectuate");
                com.Connection = conex;
                OleDbDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["ID"].ToString());
                    itm.SubItems.Add(reader["Denumire"].ToString());
                    itm.SubItems.Add(reader["Locatie"].ToString());
                    itm.SubItems.Add(reader["NrZile"].ToString());
                    itm.SubItems.Add(reader["NrCamere"].ToString());
                    //itm.SubItems.Add(reader["PretMediu"].ToString());
                    listView1.Items.Add(itm);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conex.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //cbCam.ValueMember = "0";
            //cbCam.DisplayMember = "0";
            //cbCam.Text = "0";
            if(listView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("There is no hotel selected to confirm!");
            }
            else 
            { confPnl.Visible = true;
                
            }
        }

        private void tbCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbCam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbZile_KeyPress(object sender, KeyPressEventArgs e)
        {
            sum = RandomNr(100,500); //* Convert.ToInt32(tbZile.Text) * Convert.ToInt32(cbCam.Text);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                priceLbl.Text = "Price: ";

            }
            else if (e.KeyChar == (char)Keys.Back)
                priceLbl.Text = "Price: ";
            else if (tbZile.Text.Length > 1)
            {
                sum += sum * 2;
               priceLbl.Text = "Price: " + sum;
            }
            else { priceLbl.Text = "Price: " + sum; }
           

        }

        private void tbFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public double RandomNr(double min, double max)
        {

            Random rnd = new Random();
            double calc = rnd.NextDouble() * (max - min) + min;
            return Math.Truncate(calc * 100) / 100;
        }

        private void confBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CazariEfectuate.accdb";
                OleDbConnection conex = new OleDbConnection(connStr);
                // int cbVal = Convert.ToInt32(cbCam.Text);
           
                int cbVal = int.Parse(cbCam.Text);
                int nrPers = int.Parse(tbPers.Text);
                int nrZile = int.Parse(tbZile.Text);
                
                conex.Open();
                OleDbCommand com = new OleDbCommand();
                com.Connection = conex;
                ListViewItem itm = listView1.SelectedItems[0];
                com.CommandText = "INSERT INTO cazariConfirmate VALUES(?,?,?,?,?,?,?,?,?,?)";
                com.Parameters.Add("ID", OleDbType.Integer).Value = Convert.ToInt32(itm.SubItems[0].Text);
                com.Parameters.Add("Denumire", OleDbType.Char).Value = itm.SubItems[1].Text;
                com.Parameters.Add("Locatie", OleDbType.Char).Value = itm.SubItems[2].Text;
                com.Parameters.Add("Nume", OleDbType.Char).Value = tbFName.Text;
                com.Parameters.Add("CNP", OleDbType.Char).Value = tbCNP.Text;
                com.Parameters.Add("Camere", OleDbType.Integer).Value = cbVal;
                com.Parameters.Add("NrPersoane", OleDbType.Integer).Value = nrPers;
                com.Parameters.Add("NrZile", OleDbType.Integer).Value = nrZile;
                com.Parameters.Add("PretTotal", OleDbType.Double).Value = sum * cbVal * nrZile;
                com.Parameters.Add("Avanas", OleDbType.Double).Value = 0.3 * (sum * cbVal *nrZile);
                com.ExecuteNonQuery();
                conex.Close();
                MessageBox.Show("Confirmed booking!\n Total price: " + (sum*cbVal*nrZile).ToString() + " RON");
                MessageBox.Show("You have to pay in advance 30%: " + (0.3 * (sum * cbVal * nrZile)).ToString() +" RON");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbFName.Clear();
                tbCNP.Clear();
                tbPers.Clear();
                tbZile.Clear();
                cbCam.Text = "0";
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try {
                string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CazariEfectuate.accdb";
                OleDbConnection conex = new OleDbConnection(connStr);
                conex.Open();
                OleDbCommand com = new OleDbCommand();
                com.Connection = conex;
                ListViewItem itm = listView1.SelectedItems[0];
                com.CommandText = "DELETE FROM cazariConfirmate WHERE [ID]= " + itm.SubItems[0].Text; 
                com.ExecuteNonQuery();
                com.CommandText = "DELETE FROM cazariEfectuate WHERE [ID]= " + itm.SubItems[0].Text;
                com.ExecuteNonQuery();
                conex.Close();
                listView1.Items.Remove(itm);
                MessageBox.Show("Deleted!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
    }
    
}

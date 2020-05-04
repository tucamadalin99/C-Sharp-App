using ProiectPAW_Tuca_Madalin_1048;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPaw_1048_TucaMadalin
{
    public partial class Form5 : Form
    {
       
        string[] reasons =
        {
            "I want to book a hotel by phone",
            "I would like to make a complaint",
            "I would like to contact the hotel owners",
            "I would like to pay in advance."

        };
        Cazare c1 = new Cazare();
        public Form5()
        {

            InitializeComponent();
            listBox1.AllowDrop = true;
            listBox2.AllowDrop = true;
            for(int i = 0; i < reasons.Length; i++) {
                listBox1.Items.Add(reasons[i] + "\n");
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(e.Data.GetData(DataFormats.Text));
            listBox1.Items.Remove(e.Data.GetData(DataFormats.Text));
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

     
    }
}

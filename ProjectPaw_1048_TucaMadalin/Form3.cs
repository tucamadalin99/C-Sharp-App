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

namespace ProjectPaw_1048_TucaMadalin
{
    public partial class Form3 : Form
    {
        double[] vect = new double[20];
        int[] years = new int[20];
        int n = 0;
        int nrYears = 0;
        double distance = 0.0;
        const int margin = 10;

        bool vb = false;

        Color color = Color.LightSteelBlue;
        Font font = new Font(FontFamily.GenericSansSerif, 1, FontStyle.Bold);
        public Form3()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            if(vb == true)
            {
                Graphics g = e.Graphics;
                Rectangle rect = new Rectangle(this.ClientRectangle.X + margin, this.ClientRectangle.Y + 4 * margin,
                    this.ClientRectangle.Width - 2 * margin, this.ClientRectangle.Height - 5 * margin);
                Pen pen = new Pen(Color.SteelBlue, 3);
                g.DrawRectangle(pen, rect);
                //MessageBox.Show(distance.ToString());
                int refYear = Convert.ToInt32(tbRef.Text);
                int currYear = Convert.ToInt32(tbCurr.Text);
                int nrYears = currYear - refYear;
                double width = rect.Width / nrYears / 3;
                distance = (rect.Width - nrYears * width) / (n + 1);
                int leftControl = 1;
                textBoxes[] tbs = new textBoxes[nrYears];
                double vMax = vect.Max();

                Brush br = new SolidBrush(color);
                Rectangle[] recs = new Rectangle[n];
                for(int i = 0; i < nrYears; i++)
                {
                    recs[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distance + i * width),
                        (int)(rect.Location.Y + rect.Height - vect[i] / vMax * rect.Height),
                        (int)width,
                        (int)(vect[i] / vMax * rect.Height));
                    g.DrawString(vect[i].ToString(), this.Font, br, new Point((int)(recs[i].Location.X),
                        (int)(recs[i].Location.Y - this.Font.Height)));
                    g.DrawString(refYear++.ToString(), this.Font, br, new Point((int)(recs[i].Location.X),
                        354));
                    g.FillRectangles(br, recs);
                   
                    
                    leftControl++;

                }
                for (int i = 0; i < n - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + width / 2), (int)(recs[i].Location.Y)),
                         new Point((int)(recs[i + 1].Location.X + width / 2), (int)(recs[i + 1].Location.Y)));
            }

        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            StreamReader sr = new StreamReader("data.txt");
            string line = null;
            while((line = sr.ReadLine()) != null)
            {
                try
                {
                    vect[n] =Convert.ToDouble(line);
                    n++;
                    vb = true;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Data lodaded!");
           // Invalidate();
        }

        private void yearsBtn_Click(object sender, EventArgs e)
        {
           
            //int refYear = Convert.ToInt32(tbRef.Text);
            //int currYear = Convert.ToInt32(tbCurr.Text);
            //int nrYears = currYear - refYear;
            //int leftControl = 1;
            //textBoxes[] tbs = new textBoxes[nrYears];
            //for(int i = 0; i < nrYears; i++)
            //{
            //    tbs[i] = new textBoxes();
            //    tbs[i].setLabelVal((refYear++).ToString());
            //}

            //for(int i = 0; i < nrYears; i++)
            //{
                
            //    this.Controls.Add(tbs[i]);
            //    tbs[i].Left = leftControl * 100;
            //    tbs[i].Top = 349;
            //    leftControl++;
                
            //}
            panel1.Hide();
            Invalidate();
        }

        private void textBoxes1_Load(object sender, EventArgs e)
        {

        }
    }
}

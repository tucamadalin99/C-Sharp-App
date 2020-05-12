using ProiectPAW_Tuca_Madalin_1048;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
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
        static int nrYears = 0;
        double distance = 0.0;
        const int margin = 10;
        double[] vals = new double[nrYears];
        TextBox[] tbs = new TextBox[10];
        bool vb = false;

        Color color = Color.LightSteelBlue;
        Font font = new Font(FontFamily.GenericSansSerif, 1, FontStyle.Bold);
        public Form3()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
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
                double vMax = vect.Max();

                Brush br = new SolidBrush(color);
                Rectangle[] recs = new Rectangle[nrYears];
                for(int i = 0; i < nrYears; i++)
                {
                    recs[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distance + i * width),
                        (int)(rect.Location.Y + rect.Height - vect[i] / vMax * rect.Height),
                        (int)width,
                        (int)(vect[i] / vMax * rect.Height));
                    g.DrawString(vect[i].ToString(), this.Font, br, new Point((int)(recs[i].Location.X),
                        (int)(recs[i].Location.Y - this.Font.Height)));
                    g.DrawString(refYear++.ToString(), this.Font, br, new Point((int)(recs[i].Location.X),
                        355));
                    g.FillRectangles(br, recs);
                   
                    
                    leftControl++;

                }
                try {
                    for (int i = 0; i < n - 1; i++)
                        g.DrawLine(pen, new Point((int)(recs[i].Location.X + width / 2), (int)(recs[i].Location.Y)),
                             new Point((int)(recs[i + 1].Location.X + width / 2), (int)(recs[i + 1].Location.Y)));
                }catch(Exception ex)
                {
                    MessageBox.Show("Array is full");
                }
              
            }

        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            //StreamReader sr = new StreamReader("data.txt");
            //string line = null;
            //while((line = sr.ReadLine()) != null)
            //{
            //    try
            //    {
            //        vect[n] =Convert.ToDouble(line);
            //        n++;
            //        vb = true;
            //    }catch(Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //sr.Close();
            //MessageBox.Show("Data lodaded!");
           // Invalidate();
        }
        int leftControl = 1;
        private void yearsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int firstYear = Convert.ToInt32(tbRef.Text);
                int lastYear = Convert.ToInt32(tbCurr.Text);
                nrYears = lastYear - firstYear;
                for (int i = 0; i < nrYears; i++)
                {
                    tbs[i] = new TextBox();
                    TextBox t1 = new TextBox();
                    Label l1 = new Label();
                    panel2.Controls.Add(l1);
                    panel2.Controls.Add(t1);

                    l1.Top = leftControl * 30;
                    l1.Left = 10;
                    l1.ForeColor = System.Drawing.Color.White;
                    l1.Text = firstYear.ToString();
                    t1.Top = leftControl * 30;
                    t1.Left = 130;
                    tbs[i] = t1;


                    firstYear++;
                    leftControl++;
                    yearsBtn.Enabled = false;
                    if(t1.Top >= panel2.Height)
                    {
                        MessageBox.Show("Too many values!");
               
                        this.Invalidate();
            
                        panel2.Controls.Clear();
                        yearsBtn.Enabled = true;
                        break;
                    }
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("No input or invalid format!");
                yearsBtn.Enabled = true;
            }
         
           
            //panel2.Hide();
            //Invalidate();
        }
        private void textBoxes1_Load(object sender, EventArgs e)
        {

        }
        private void loadBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                try
                {
                    StreamWriter sw = new StreamWriter("data.txt");
                    for (int i = 0; i < nrYears; i++)
                    {

                        sw.WriteLine(tbs[i].Text);

                    }
                   
                    sw.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
             
                    for (int i = 0; i < nrYears; i++)
                    {
                        vect[i] = Convert.ToDouble(tbs[i].Text);
                    }
              

                try
                {
                    StreamReader sr = new StreamReader("data.txt");
                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        try
                        {
                            vect[n] = Convert.ToDouble(line);
                            n++;
                            vb = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }
                    sr.Close();
                    //MessageBox.Show("Data lodaded!");
                    panel1.Hide();
                    panel2.Hide();
                    Invalidate();
                    loadBtn.Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }catch(FormatException ex)
            {
                MessageBox.Show("No data input in each year or invalid format!");
                loadBtn.Visible = true;
                
            }
            
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                color = dlg.Color;
            }
            Invalidate();
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                font = dlg.Font;
            }
            Invalidate();
        }

        private void save(Control c, string denumire)
        {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y, c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(denumire);
            img.Dispose();
        }

        private void saveAsBmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save(this, "GraphReport.bmp");
            MessageBox.Show("Report saved in bin/Debug!");
        }

        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                Rectangle rect = new Rectangle(e.PageBounds.X + margin, e.PageBounds.Y + 2 * margin,
                    e.PageBounds.Width - 2 * margin, e.PageBounds.Height - 3 * margin);
                Pen pen = new Pen(Color.SteelBlue, 3);
                g.DrawRectangle(pen, rect);
                //MessageBox.Show(distance.ToString());
                int refYear = Convert.ToInt32(tbRef.Text);
                int currYear = Convert.ToInt32(tbCurr.Text);
                int nrYears = currYear - refYear;
                double width = rect.Width / nrYears / 3;
                distance = (rect.Width - nrYears * width) / (n + 1);
                int leftControl = 1;

                double vMax = vect.Max();

                Brush br = new SolidBrush(color);
                Rectangle[] recs = new Rectangle[nrYears];
                for (int i = 0; i < nrYears; i++)
                {
                    recs[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distance + i * width),
                        (int)(rect.Location.Y + rect.Height - vect[i] / vMax * rect.Height),
                        (int)width,
                        (int)(vect[i] / vMax * rect.Height));
                    g.DrawString(vect[i].ToString(), this.Font, br, new Point((int)(recs[i].Location.X),
                        (int)(recs[i].Location.Y - this.Font.Height)));
                    g.DrawString(refYear++.ToString(), this.Font, br, new Point((int)(recs[i].Location.X),
                        355));
                    g.FillRectangles(br, recs);


                    leftControl++;

                }
                for (int i = 0; i < n - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + width / 2), (int)(recs[i].Location.Y)),
                         new Point((int)(recs[i + 1].Location.X + width / 2), (int)(recs[i + 1].Location.Y)));
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pdPrint);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void deleteDatabseToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
                var rezultat = MessageBox.Show(this,
             $"Are you sure?",
             "Database cleared",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);
                if (rezultat == DialogResult.Yes)
                {
                try
                {
                    string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CazariEfectuate.accdb";
                    OleDbConnection conex = new OleDbConnection(connStr);
                    conex.Open();
                    OleDbCommand com = new OleDbCommand();
                    com.Connection = conex;
                    com.CommandText = "DELETE * FROM cazariEfectuate";
                    com.ExecuteNonQuery();
                    conex.Close();
                    MessageBox.Show("Database has been cleared!");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }
                else
                {
                MessageBox.Show("Nothing was deleted.");
                }
                
        }

        private void openDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            
        }
    }
}

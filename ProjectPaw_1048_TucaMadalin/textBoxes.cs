using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPaw_1048_TucaMadalin
{
    public partial class textBoxes : UserControl
    {
        public textBoxes()
        {
            InitializeComponent();
        }

        public string getLabelVal()
        {
            return this.label1.Text;
        }

        public void setLabelVal(string newText)
        {
            this.label1.Text = newText;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_2
{
    public partial class dialoogVenster : Form
    {
        public int newNumber { get; set; }
        public bool notGood { get; set; }

        public dialoogVenster()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(tbValue.Text == "")
            {
                notGood = true;
            }
            else
            {
                newNumber = int.Parse(tbValue.Text);
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            notGood = true;
            this.Close();
        }
    }
}

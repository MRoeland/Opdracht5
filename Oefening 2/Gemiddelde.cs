using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_2
{
    public partial class Gemiddelde : Form
    {
        public Gemiddelde()
        {
            InitializeComponent();
        }

        private void btnNewNumber_Click(object sender, EventArgs e)
        {
            dialoogVenster dialog = new dialoogVenster();
            dialog.ShowDialog();
            int number = dialog.newNumber;
            bool notGood = dialog.notGood;

            if (notGood == false)
            {
                LBNumbers.Items.Add(number);
            }

            int lstCount = LBNumbers.Items.Count;
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < lstCount; i++)
            {
                sum += Convert.ToDouble(LBNumbers.Items[i]);
            }
            avg = sum / lstCount;

            tbAverage.Text = avg.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_3
{
    public partial class Kleur : Form
    {
        public int Alpha { get; set; }

        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public Kleur(int alpha, int red, int green, int blue)
        {
            Alpha = alpha;
            Red = red;
            Green = green;
            Blue = blue;

            InitializeComponent();
        }

        private void Kleur_Load(object sender, EventArgs e)
        {
            tbAlpha.Text = Alpha.ToString();
            tbRed.Text = Red.ToString();
            tbGreen.Text = Green.ToString();
            tbBlue.Text = Blue.ToString();

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

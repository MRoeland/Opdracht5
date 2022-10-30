namespace Oefening_1
{
    public partial class Form1 : Form
    {

        Font SmallFont = new Font("Arial", 8);
        Font MediumFont = new Font("Arial", 12);
        Font LargeFont = new Font("Arial", 16);

        public Form1()
        {
            InitializeComponent();
        }


        // context menu
        // Rechtermuisknop werkt als je buiten de textbox de rechtermuisknop indrukt

        // font color

        private void CMSRedFont_Click(object sender, EventArgs e)
        {
            tbText.SelectionColor = Color.Red;
        }

        private void CMSGreenFont_Click(object sender, EventArgs e)
        {
            tbText.SelectionColor = Color.Green;
        }

        private void CMSBlueFont_Click(object sender, EventArgs e)
        {
            tbText.SelectionColor = Color.Blue;
        }

        // background

        private void CMSRedBackround_Click(object sender, EventArgs e)
        {
            tbText.BackColor = Color.Red;   
        }

        private void CMSGreenBackground_Click(object sender, EventArgs e)
        {
            tbText.BackColor = Color.Green;
        }

        private void CMSBlueBackground_Click(object sender, EventArgs e)
        {
            tbText.BackColor = Color.Blue;
        }

        // font size

        private void CMSSmallFont_Click(object sender, EventArgs e)
        {
            tbText.Font = SmallFont;
        }

        private void CMSNormalFont_Click(object sender, EventArgs e)
        {
            tbText.Font = MediumFont;
        }

        private void CMSLargeFont_Click(object sender, EventArgs e)
        {
            tbText.Font = LargeFont;
        }

        // menu strip

        private void MSExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // font color

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = Color.Blue;
        }
        
        // background

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbText.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbText.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbText.BackColor = Color.Blue;
        }

        // font size

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.Font = SmallFont;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.Font = MediumFont;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.Font = LargeFont;
        }
    }
}
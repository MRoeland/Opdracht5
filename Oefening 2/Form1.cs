namespace Oefening_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Gemiddelde child = new Gemiddelde();
            child.MdiParent = this;
            child.Size = this.Size;
            child.Show();
        }
    }
}
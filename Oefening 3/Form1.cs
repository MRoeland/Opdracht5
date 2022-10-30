namespace Oefening_3;
using System.Drawing;

public partial class Form1 : Form
{

    List<Rechthoek> rectangles = new List<Rechthoek>();

    int seed = 69;


    int matrix = 1;
    int currentWidth;
    int currentHeight;
    int columnIndex = 0;
    int rowIndex = 0;

    int formWidth;
    int formHeight;

    Rechthoek r;

    Random rand;

    Kleur kleurForm;
    public Form1()
    {
        InitializeComponent();
        currentWidth = this.Width;
        currentHeight = this.Height;

        formWidth = this.Width;
        formHeight = this.Height;
    }

    private void TSPAdd_Click(object sender, EventArgs e)
    {
        Graphics g;
        g = this.CreateGraphics();

        if(rectangles.Count < (matrix * matrix))
        {
            seed = rectangles.Count();
            rand = new Random(Seed: seed);
            r = new Rechthoek(((columnIndex * currentWidth)), (rowIndex * currentHeight), currentWidth, currentHeight, rand.Next(0,256), rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));

            rectangles.Add(r);

            if (columnIndex < matrix - 1)
            {
                columnIndex++;
            }
            else
            {
                rowIndex++;
                columnIndex = 0;
            }
        }
        else
        {
            seed = rectangles.Count();
            rand = new Random(Seed: seed);
            r = new Rechthoek((columnIndex * currentWidth), (rowIndex * currentHeight), currentWidth, currentHeight, rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));

            rectangles.Add(r);

            matrix++;
            columnIndex = 0;
            rowIndex = 0;

            currentWidth = formWidth / matrix;
            currentHeight = formHeight / matrix;

            for(int i = 0; i < rectangles.Count; i++)
            {
                r = rectangles[i];

                r.posX = columnIndex * currentWidth;
                r.posY = rowIndex * currentHeight;
                r.width = currentWidth;
                r.height = currentHeight;

                if(columnIndex < matrix - 1)
                {
                    columnIndex++;
                }
                else
                {
                    rowIndex++;
                    columnIndex = 0;
                }
            }
        }

        g.Clear(Color.White);

        foreach(var r in rectangles)
        {
            Rectangle rectangle = new Rectangle(r.posX, r.posY, r.width, r.height);
            Color c = Color.FromArgb(r.alpha, r.red, r.green, r.blue);
            SolidBrush b = new SolidBrush(c);


            g.FillRectangle(b, rectangle);
        }

    }

    private void TSPDelete_Click(object sender, EventArgs e)
    {
        Graphics g;
        g = this.CreateGraphics();

        if (matrix > 1 && rectangles.Count - 1 <= ((matrix - 1) * (matrix - 1))) {

            rectangles.RemoveAt(rectangles.Count -1);

            matrix--;
            columnIndex = 0;
            rowIndex = 0;

            currentWidth = formWidth / matrix;
            currentHeight = formHeight / matrix;

            for (int i = 0; i < rectangles.Count; i++)
            {
                r = rectangles[i];

                r.posX = columnIndex * currentWidth;
                r.posY = rowIndex * currentHeight;
                r.width = currentWidth;
                r.height = currentHeight;

                if (columnIndex < matrix - 1)
                {
                    columnIndex++;
                }
                else
                {
                    rowIndex++;
                    columnIndex = 0;
                }
            }
        }
        else
        {
            rectangles.RemoveAt(rectangles.Count - 1);

            if (columnIndex > 0)
            {
                columnIndex--;
            }
            else
            {
                columnIndex = matrix - 1;
                if(rowIndex > 0)
                {
                    rowIndex--;
                };
            }
        }

        g.Clear(Color.White);

        foreach (var r in rectangles)
        {
            Rectangle rectangle = new Rectangle(r.posX, r.posY, r.width, r.height);
            Color c = Color.FromArgb(r.alpha, r.red, r.green, r.blue);
            SolidBrush b = new SolidBrush(c);


            g.FillRectangle(b, rectangle);
        }
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
        int indexRechthoek = -1;

        for(int i = 0; i < rectangles.Count; i++)
        {
            Rectangle rect = new Rectangle(rectangles[i].posX, rectangles[i].posY, rectangles[i].width, rectangles[i].height);
            if (rect.Contains(e.Location))
            {
                indexRechthoek = i;
                if (!rectangles[i].isFocused)
                {
                    rectangles[i].isFocused = true;
                }
            }
        }

        if(indexRechthoek > -1)
        {
            kleurForm = new Kleur(rectangles[indexRechthoek].alpha, rectangles[indexRechthoek].red, rectangles[indexRechthoek].green, rectangles[indexRechthoek].blue);

            if ((Application.OpenForms["Kleur"] as Kleur) != null)
            {
                kleurForm.Close();
            }
            else
            {
                kleurForm.Show();

                Graphics g;
                g = this.CreateGraphics();

                rectangles[indexRechthoek].alpha = kleurForm.Alpha;
                rectangles[indexRechthoek].red = kleurForm.Red;
                rectangles[indexRechthoek].green = kleurForm.Green;
                rectangles[indexRechthoek].blue = kleurForm.Blue;

                Rectangle rectangle = new Rectangle(rectangles[indexRechthoek].posX, rectangles[indexRechthoek].posY, rectangles[indexRechthoek].width, rectangles[indexRechthoek].height);
                Color c = Color.FromArgb(rectangles[indexRechthoek].alpha, rectangles[indexRechthoek].red, rectangles[indexRechthoek].green, rectangles[indexRechthoek].blue);
                SolidBrush b = new SolidBrush(c);

                g.FillRectangle(b, rectangle);
            }
        }
    }
}
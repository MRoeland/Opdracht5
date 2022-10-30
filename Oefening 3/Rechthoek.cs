using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_3
{
    internal class Rechthoek
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int alpha { get; set; }
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }
        public bool isFocused { get; set; }

        public Rechthoek()
        {

        }

        public Rechthoek(int posX, int posY, int width, int height, int alpha, int red, int green, int blue)
        {
            this.posX = posX;
            this.posY = posY;
            this.width = width;
            this.height = height;
            this.alpha = alpha;
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
    }
}

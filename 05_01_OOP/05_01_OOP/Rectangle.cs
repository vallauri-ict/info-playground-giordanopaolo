using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_01_OOP
{
    class Rectangle
    {
        private int b, h;
        public Color Colore;
        public Rectangle()
        {
            b = 1;
            h = 2;
        }
        public Rectangle(int x, int j)
        {
            b = x;
            h = j;
        }
        public string getsides()
        {
            return b.ToString() + " " + h.ToString();
        }
    }
}


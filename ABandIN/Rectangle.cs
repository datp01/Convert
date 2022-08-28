using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABandIN
{
    internal class Rectangle
    {
        int Width;
        int Height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            DrawLine(this.Width, '*', '*');
            for (int i = 1; i< this.Height -1;i++)
            {
                DrawLine(this.Width, ' ', '*');
            }
            DrawLine(this.Width, '*', '*');
        }
        private void DrawLine(int Width,char end,char mid)
        {
            Console.Write(end);
            for ( int i = 1;i<Width -1;i++)
            {
                Console.Write(mid);
            }
            Console.Write(end);
        }
    }
}

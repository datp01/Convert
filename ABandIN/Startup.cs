using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABandIN
{
    internal class Startup: IDrawable
    {
        static void Main()
        {

            var Radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(Radius);

            var Width = int.Parse(Console.ReadLine());
            var Height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(Width, Height);

            circle.Draw();
            rect.Draw();

        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Circle : Ellipse
    {
        public int radius { get { return mainAxis; } set { mainAxis = value; additionalAxis = value; } }

        public Circle(int x1, int y1, int r):base(x1,y1,r,r)
        {
        }

        public override string FigureName() { return "круг"; }
        public override void ShowFigure()
        {
            Console.WriteLine(
                $"Это {FigureName()} с центром в точке ({x},{y}) и радиусом {radius} \n");
            Console.WriteLine();
        }
    }
}

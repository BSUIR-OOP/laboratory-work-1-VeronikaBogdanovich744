using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Rectangle : Parallelogram
    {
        public Rectangle(int x1, int y1, int x2, int y2) : base(x1, y1, x1, y2, x2, y2, x2, y1)
        {

        }
         public override string FigureName() { return "прямоугольник"; }

        public override void ShowFigure()
        {
            Console.WriteLine(
                 $"Это прямоугольник с координатами противоположных углов ({this.x1},{this.y1}),({this.x2},{this.y2}) \n");
            Console.WriteLine();
        }
    }
}


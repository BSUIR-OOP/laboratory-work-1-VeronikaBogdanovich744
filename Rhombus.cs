using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Rhombus:Quadrangle
    {
        private int x1, y1;
        private int x2, y2;
        private int x3, y3;
        private int x4, y4;
        public Rhombus(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1, x2, y2, x3, y3, x1, y2)
        {
            /* this.x1 = x1;
             this.y1 = y1;
             this.x2 = x2;
             this.y2 = y2;*/
        }
        public override string FigureName() { return "параллелограмм"; }
        public override void ShowFigure()
        {
            Console.WriteLine(
                $"Это {FigureName()} с координатами противоположных углов({x1},{y1}),({x2},{y2}) \n");
            Console.WriteLine();
        }
    }
}

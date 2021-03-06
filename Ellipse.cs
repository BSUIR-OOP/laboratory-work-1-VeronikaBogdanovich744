using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Ellipse: BaseFigure
    {
        private protected int mainAxis, additionalAxis;
        private protected int x, y;
        public virtual int mainAx { get { return mainAxis; } set { mainAxis = value; } }
        public virtual int additionalAx { get { return additionalAxis; } set { additionalAxis = value; } }
        public int p_x { get { return x; } set { x = value; } }
        public int p_y { get { return y; } set { y = value; } }

        public Ellipse(int x1,int y1, int axis1,int axis2)
        {
            mainAxis = axis1;
            additionalAxis = axis2;
            x = x1;
            y = y1;
        }

        public override string FigureName() { return "эллипс"; }
        public override void ShowFigure() {
            Console.WriteLine(
                $"Это {FigureName()} с центром в точке ({x},{y}) и полуосями ({mainAxis},{additionalAxis}) \n"); 
            Console.WriteLine();
        }
    }
}

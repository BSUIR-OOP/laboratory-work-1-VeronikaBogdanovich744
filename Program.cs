using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<BaseFigure>()
            {
            new Ellipse(1, 1, 30, 40),
            new Circle(1, 1, 30),
            new Triangle(10, 10, 20, 20, 10, 20),
            new Quadrangle(10, 10, 20, 20, 20, 30, 10, 40),
            new Parallelogram(10, 10, 20, 40, 40, 40, 30, 10),
            new Rectangle(10, 10, 30, 30)
            };
        
            foreach(var f in figures)
            {
                f.ShowFigure();
            }
        
            Console.ReadKey();
        }
    }
}

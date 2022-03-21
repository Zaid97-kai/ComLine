using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ShapeContainer
    {
        public static List <Figure> figureList;
        public ShapeContainer()
        {
            figureList = new List<Figure>();
        }
        public static void AddFigure(Figure figure)
        {
            figureList.Add(figure);
        }
    }
}

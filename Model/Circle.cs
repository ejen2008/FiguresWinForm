using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWinForm.Model
{
    [Serializable]
    public class Circle : Figure
    {
        private static int numberObject;

        public Circle()
        { }
        public Circle(string nameFigure) :
            base(nameFigure + ++numberObject)
        {
        }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Cyan, 2.1f), LocationFigure.X, LocationFigure.Y, SizeFigure, SizeFigure);
        }
    }
}

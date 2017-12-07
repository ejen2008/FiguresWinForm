using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWinForm.Model
{
    [DataContract]
    [Serializable]
    public class Square : Figure
    {
        private static int numberObject;

        public Square()
        { }
        public Square(string nameFigure) :
            base(nameFigure + ++numberObject)
        {
        }

        public override void Draw(Graphics g)
        {
            int secondAngleFigureX = LocationFigure.X+SizeFigure;
            int secondAngleFigureY = LocationFigure.Y+SizeFigure;
            
            Point[] points =
                {
                new Point(LocationFigure.X, LocationFigure.Y),
                new Point(LocationFigure.X, secondAngleFigureY),
                new Point(LocationFigure.X, LocationFigure.Y),
                new Point(secondAngleFigureX, LocationFigure.Y),
                new Point (secondAngleFigureX, secondAngleFigureY),
                new Point (LocationFigure.X,secondAngleFigureY)
                };
            g.DrawLines(new Pen(Color.Chartreuse, 2.1f), points);
        }
    }
}

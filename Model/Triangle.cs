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
    public class Triangle : Figure
    {
        private static int numberObject;

        public Triangle()
        { }
        public Triangle(string nameFigure) :
            base(nameFigure + ++numberObject)
        {
        }
        public override void Draw(Graphics g)
        {
            int vertexTriangleX = LocationFigure.X + SizeFigure/2;
            int vertexTriangleY = LocationFigure.Y;
            int secondAngleFigureX = LocationFigure.X + SizeFigure;
            int secondAngleFigureY = LocationFigure.Y + SizeFigure;

            Point[] points =
                {
                new Point(vertexTriangleX, vertexTriangleY),
                new Point(secondAngleFigureX, secondAngleFigureY),
                new Point(LocationFigure.X, secondAngleFigureY),
                new Point(vertexTriangleX, vertexTriangleY)
                };
            g.DrawLines(new Pen(Color.Green, 2.1f), points);
        }
    }
}

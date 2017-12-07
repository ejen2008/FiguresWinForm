using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresWinForm.Model;
using System.Xml.Serialization;
using System.IO;


namespace FiguresWinForm.Serialize
{
    class XMLFormatSerialize : ISerialize
    {
         public void WriteData(List<Figure> listOfFigures, string filePath)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Figure>),
                new Type[] { typeof(Square), typeof(Circle), typeof(Triangle) });
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, listOfFigures);
            }
        }
        public List<Figure> ReadData(string filePath)
        {
            List<Figure> figure = null;
            if (File.Exists(filePath))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Figure>),
                new Type[] { typeof(Square), typeof(Circle), typeof(Triangle) });
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    figure = formatter.Deserialize(fileStream) as List<Figure>;
                }
            }
            return figure;
        }
    }
}


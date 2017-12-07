using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresWinForm.Model;
using System.Runtime.Serialization.Json;
using System.IO;

namespace FiguresWinForm.Serialize
{
    class JSONFormatSerialize : ISerialize
    {
        public void WriteData(List<Figure> listOfFigures, string filePath)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Figure>),
            new Type[] { typeof(Square), typeof(Circle), typeof(Triangle) });
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(fileStream, listOfFigures);
            }
        }
        public List<Figure> ReadData(string filePath)
        {
            List<Figure> figure = null;
            if (File.Exists(filePath))
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Figure>),
            new Type[] { typeof(Square), typeof(Circle), typeof(Triangle) });
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    figure = jsonSerializer.ReadObject(fileStream) as List<Figure>;
                }
            }
            return figure;
        }
    }
}

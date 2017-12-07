using FiguresWinForm.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWinForm.Serialize
{
    class BinFormatSerialize : ISerialize
    {
        public void WriteData(List<Figure> figures, string filePath)
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(fileStream, figures);
            }
        }

        public List<Figure> ReadData(string filePath)
        {
            List<Figure> figure = null;
            if (File.Exists(filePath))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    figure = binaryFormatter.Deserialize(fileStream) as List<Figure>;
                }
            }
            return figure;
        }
    }
}

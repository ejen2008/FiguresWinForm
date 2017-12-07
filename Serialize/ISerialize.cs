using FiguresWinForm.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWinForm.Serialize
{
    interface ISerialize
    {
        void WriteData(List<Figure> listOfFigures, string filePath);
        List<Figure> ReadData(string filePath);
    }
}

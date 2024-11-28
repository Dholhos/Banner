using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IBannerOperations
    {
        /// <summary>
        /// Feketére színezi a teljes kijelzőt
        /// </summary>
        public void Clear();
        /// <summary>
        /// Egx pixellel elforgatja balra a képet
        /// </summary>
        public void RotateLeft();
        public void RotateRight();

        public void ShiftToLeft(Color fillColor);
        public void ShiftToRight(Color fillColor);
        public void DrawLine(int rowIndex, Color DrawingColor);
    }
}

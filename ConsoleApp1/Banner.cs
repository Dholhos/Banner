using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Banner : ABanner, IBannerOperations
    {
        public void Clear()
        {
            if (this != null)
            {
                for (int i = 0; i < this.RowNum; i++)
                {
                    for (int j = 0; j < this.ColumnNum; j++)
                    {
                        this[i, j] = Color.Empty; 
                    }
                }
            }
        }

        public void DrawLine(int rowIndex, Color DrawingColor)
        {
            for (int col = 0; col < this.ColumnNum; col++)
            {
                this[rowIndex, col] = DrawingColor;
            }
        }

        public void RotateLeft()
        {
            for (int rowIndex = 0; rowIndex < this.RowNum; rowIndex++)
            {
                double temp = this[RowNum, ColumnNum-1];
                for (int columnIndex = 1; columnIndex < this.ColumnNum; columnIndex++)
                {
                    this[rowIndex, columnIndex - 1] = this[rowIndex, columnIndex];
                }
                this[rowIndex, this.RowNum - 1] = temp;
            }
        }

        public void RotateRight()
        {
            throw new NotImplementedException();
        }

        public void ShiftToLeft(Color fillColor)
        {
            throw new NotImplementedException();
        }

        public void ShiftToRight(Color fillColor)
        {
            throw new NotImplementedException();
        }
    }
}

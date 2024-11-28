using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ABanner
    {
        const int MAX_ROWNUM = 30;
        const int MAX_COLUMNNUM = 1000;
        const int MIN_ROWNUM = 8;
        const int MIN_COLUMNNUM = 20;

        private Color[,] @this;

        protected ABaner(int rowNum, int columnNumber)
        {
            if (rowNum < MIN_ROWNUM || rowNum > MAX_ROWNUM || columnNumber > MAX_COLUMNNUM || columnNumber < MIN_ROWNUM)
                throw new Exception("hiba");
            @this[rowNum, columnNumber] = new();
        }
        protected ABanner() : this(MIN_ROWNUM, MIN_COLUMNNUM)
        {

        }

        public int RowNum => @this.GetLength(0);
        public int ColumnNum => @this.GetLength(1);

        public Color this[int rowIndex, int colIndex]
        {
            get
            {
                if (rowIndex < MIN_ROWNUM || rowIndex > MAX_ROWNUM || colIndex > MAX_COLUMNNUM || colIndex < MIN_ROWNUM)
                    throw new Exception("hiba");
                return @this[rowIndex, colIndex];
            }
            set
            {
                if (rowIndex < MIN_ROWNUM || rowIndex > MAX_ROWNUM || colIndex > MAX_COLUMNNUM || colIndex < MIN_ROWNUM)
                    throw new Exception("hiba");
                @this[rowIndex, colIndex] = new();
            }
        }
    }
}

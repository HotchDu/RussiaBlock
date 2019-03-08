using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussiaBlock.Entities
{
    struct CellPositon
    {
        int rowIndex;

        public int RowIndex
        {
            get { return rowIndex; }
            set { rowIndex = value; }
        }

        int colIndex;
        public int ColIndex
        {
            get { return colIndex; }
            set { colIndex = value; }
        }
    }
}

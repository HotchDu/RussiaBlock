using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussiaBlock.Entities
{
    //对结构的学习，此处使用结构存在问题，需要关注
    class CellPositon
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

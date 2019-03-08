using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussiaBlock.Entities
{
    /// <summary>
    /// 形状单元
    /// </summary>
    class ShapeUnit
    {
        CellPositon position;
        internal CellPositon Position
        {
            get { return position; }
            set { position = value; }
        }

        public void DrawUnit(Graphics g)
        {
            //填充时坐标需要注意
            g.FillRectangle(new SolidBrush(Util.CommonHelper.DefaultShapeColor), position.ColIndex * Util.CommonHelper.CellWidth + 1, position.RowIndex * Util.CommonHelper.CellWidth + 1, Util.CommonHelper.CellWidth - 1, Util.CommonHelper.CellWidth - 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussiaBlock.Entities
{
    class Shape
    {

        public void DrawShape(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Util.CommonHelper.DefaultShapeColor), Util.CommonHelper.MidIndex * Util.CommonHelper.CellWidth + 1, 0 * Util.CommonHelper.CellWidth + 1, Util.CommonHelper.CellWidth - 1, Util.CommonHelper.CellWidth - 1);
            g.FillRectangle(new SolidBrush(Util.CommonHelper.DefaultShapeColor), Util.CommonHelper.MidIndex * Util.CommonHelper.CellWidth + 1, 1 * Util.CommonHelper.CellWidth + 1, Util.CommonHelper.CellWidth - 1, Util.CommonHelper.CellWidth - 1);
            g.FillRectangle(new SolidBrush(Util.CommonHelper.DefaultShapeColor), Util.CommonHelper.MidIndex * Util.CommonHelper.CellWidth + 1, 2 * Util.CommonHelper.CellWidth + 1, Util.CommonHelper.CellWidth - 1, Util.CommonHelper.CellWidth - 1);
            g.FillRectangle(new SolidBrush(Util.CommonHelper.DefaultShapeColor), (Util.CommonHelper.MidIndex + 1) * Util.CommonHelper.CellWidth + 1, 2 * Util.CommonHelper.CellWidth + 1, Util.CommonHelper.CellWidth - 1, Util.CommonHelper.CellWidth - 1);
        }
    }
}

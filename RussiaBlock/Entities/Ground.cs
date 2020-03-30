using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussiaBlock.Entities
{
    class Ground
    {
        /// <summary>
        /// 画图，完成背景表格的绘画
        /// </summary>
        /// <param name="g">画笔</param>
        public void DrawGround(Graphics g)
        {           
            for (int rowIndex = 0; rowIndex < Util.CommonHelper.RowCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < Util.CommonHelper.ColCount; colIndex++)
                {
                    //水平坐标与列相关  竖直坐标与行相关
                    g.DrawRectangle(new Pen(Util.CommonHelper.DefaultGirdColor), colIndex * Util.CommonHelper.CellWidth, rowIndex * Util.CommonHelper.CellWidth, Util.CommonHelper.CellWidth, Util.CommonHelper.CellWidth);
                    //完成网格的绘画，为何要填充？有无必要？
                    //对于坐标以及画笔的宽度如何正确的理解和使用：所谓的宽度，是以坐标为中心，向外扩散而来。在填充的过程中，之所以存在+1和-1的情况，是因为，填充需要考虑边界，不能失去边框，否则无意义。
                    g.FillRectangle(new SolidBrush(Util.CommonHelper.DefaultbgColor), colIndex * Util.CommonHelper.CellWidth + 1, rowIndex * Util.CommonHelper.CellWidth + 1, Util.CommonHelper.CellWidth - 1, Util.CommonHelper.CellWidth - 1);
                }
            }
        }
    }
}

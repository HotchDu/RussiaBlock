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
        /// //画图，完成表格的绘画
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
                    g.FillRectangle(new SolidBrush(Util.CommonHelper.DefaultbgColor), colIndex * Util.CommonHelper.CellWidth + 1, rowIndex * Util.CommonHelper.CellWidth + 1, Util.CommonHelper.CellWidth - 1, Util.CommonHelper.CellWidth - 1);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussiaBlock.Util
{
    class CommonHelper
    {
        static int rowCount = 20;
        public static int RowCount
        {
            get { return rowCount; }
            set { rowCount = value; }
        }

        static int colCount = 16;
        public static int ColCount
        {
            get { return colCount; }
            set { colCount = value; }
        }

        //单元格的宽高
        static int cellWidth;
        public static int CellWidth
        {
            get { return cellWidth; }
            set { cellWidth = value; }
        }


        //默认网格色
        static Color defaultGirdColor = Color.Black;
        public static Color DefaultGirdColor
        {
            get { return defaultGirdColor; }
            set { defaultGirdColor = value; }
        }

        //默认背景色
        static Color defaultbgColor = Color.White;
        public static Color DefaultbgColor
        {
            get { return defaultbgColor; }
            set { defaultbgColor = value; }
        }

        //默认的形状色
        static Color defaultShapeColor = Color.SkyBlue;
        public static Color DefaultShapeColor
        {
            get { return defaultShapeColor; }
            set { defaultShapeColor = value; }
        }

        //默认的障碍色
        static Color defaultObstacleColor = Color.Yellow;
        public static Color DefaultObstacleColor
        {
            get { return defaultObstacleColor; }
            set { defaultObstacleColor = value; }
        }

        //形状出现时的中间坐标
        static int midIndex;
        public static int MidIndex
        {
            get { return midIndex; }
            set { midIndex = value; }
        }

        /// <summary>
        /// 计算整个游戏中公用值
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static Size SetValue(int width, int height)
        {
            MidIndex = ColCount / 2;

            int w = width / colCount;
            int h = height / rowCount;
            //确保图形的大小统一
            cellWidth = w > h ? h : w;
            //cellWidth * colCount + 1  为什么+1？返回的是容器的大小，图形从内部开始绘画，增大容器
            return new Size(cellWidth * colCount + 1, cellWidth * rowCount + 1);
        }

    }
}

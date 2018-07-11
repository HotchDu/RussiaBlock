using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussiaBlock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlGame.Size = Util.CommonHelper.SetValue(pnlGame.Width, pnlGame.Height);
        }

        /// <summary>
        /// 开始游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //创建画笔  句柄
            //参数决定了在哪个控件上进行画
            //Graphics g = Graphics.FromHwnd(pnlGame.Handle);
            Graphics g = pnlGame.CreateGraphics();
            //g.DrawRectangle(new Pen(Color.Red),0,0,100,100);
            //g.DrawEllipse(Pens.Blue, 20, 20, 40, 40);
            //fill 可以绘制内部填充
            //g.FillRectangle(new SolidBrush(Color.White), 0, 0, 30, 30);

            #region 画图，完成表格的绘画
            //画图
            for (int rowIndex = 0; rowIndex < Util.CommonHelper.RowCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < Util.CommonHelper.ColCount; colIndex++)
                {
                    //水平坐标与列相关  竖直坐标与行相关
                    g.DrawRectangle(new Pen(Util.CommonHelper.DefaultGirdColor), colIndex*Util.CommonHelper.CellWidth, rowIndex* Util.CommonHelper.CellWidth, Util.CommonHelper.CellWidth, Util.CommonHelper.CellWidth);
                    g.FillRectangle(new SolidBrush(Util.CommonHelper.DefaultbgColor), colIndex * Util.CommonHelper.CellWidth + 1, rowIndex * Util.CommonHelper.CellWidth + 1, Util.CommonHelper.CellWidth - 1, Util.CommonHelper.CellWidth - 1);
                }
            }
            #endregion

            g.FillRectangle(new SolidBrush(Util.CommonHelper.DefaultShapeColor), Util.CommonHelper.MidIndex * Util.CommonHelper.CellWidth + 1, 0 * Util.CommonHelper.CellWidth + 1 , Util.CommonHelper.CellWidth - 1, Util.CommonHelper.CellWidth - 1);
            g.FillRectangle(new SolidBrush(Util.CommonHelper.DefaultShapeColor), Util.CommonHelper.MidIndex * Util.CommonHelper.CellWidth + 1, 1 * Util.CommonHelper.CellWidth + 1, Util.CommonHelper.CellWidth - 1, Util.CommonHelper.CellWidth - 1);
            g.FillRectangle(new SolidBrush(Util.CommonHelper.DefaultShapeColor), Util.CommonHelper.MidIndex * Util.CommonHelper.CellWidth + 1, 2 * Util.CommonHelper.CellWidth + 1, Util.CommonHelper.CellWidth - 1, Util.CommonHelper.CellWidth - 1);
            g.FillRectangle(new SolidBrush(Util.CommonHelper.DefaultShapeColor), (Util.CommonHelper.MidIndex + 1) * Util.CommonHelper.CellWidth + 1, 2 * Util.CommonHelper.CellWidth + 1, Util.CommonHelper.CellWidth - 1, Util.CommonHelper.CellWidth - 1);
            


        }
    }
}

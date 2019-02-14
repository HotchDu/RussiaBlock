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
            //调用方法调用公共成员的值，同时修改面板的宽和高
            pnlGame.Size = Util.CommonHelper.SetValue(pnlGame.Width, pnlGame.Height);
        }

        /// <summary>
        /// 开始游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            Graphics g = pnlGame.CreateGraphics();        
            Entities.Ground ground = new Entities.Ground();
            ground.DrawGround(g);

            Entities.Shape shape = new Entities.Shape();
            shape.DrawShape(g);
            //g.DrawRectangle(new Pen(Color.Red),0,0,100,100);
            //g.DrawEllipse(Pens.Blue, 20, 20, 40, 40);
            //fill 可以绘制内部填充
            //g.FillRectangle(new SolidBrush(Color.White), 0, 0, 30, 30);
        }
    }
}

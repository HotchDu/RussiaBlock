using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussiaBlock.Entities
{
    abstract class Shape
    {
        public Shape()
        {
            for (int i = 0; i < units.Length; i++)
            {
                units[i] = new ShapeUnit();
            }
            //只有子类对象的创建能够调用到这个构造函数，也就意味着真正调用这个方法是子类对象，根绝堕胎的原理，会调用子类已经重写的方法
            SetUnits();
        }
        ShapeUnit[] units = new ShapeUnit[4];

        /// <summary>
        /// 组成形状的四个单元
        /// </summary>
        internal ShapeUnit[] Units
        {
            get { return units; }
            set { units = value; }
        }

        /// <summary>
        /// 父类只是规范每一个不同的形状子类都必须去确定各自形状的四个单元的坐标值
        /// </summary>
        public abstract void SetUnits();
        public void DrawShape(Graphics g)
        {
            //绘制形状的四个单元
            for (int i = 0; i < this.units.Length; i++)
            {
                units[i].DrawUnit(g);
            }
            
        }
    }
}

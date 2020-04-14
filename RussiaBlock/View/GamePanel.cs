using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RussiaBlock.View
{
    class GamePanel
    {
        IntPtr intptr;
        public GamePanel(IntPtr intptr)
        {
            this.intptr = intptr;
        }

        Graphics g;
        public Graphics G
        {
            get
            {
                if(g == null)
                {
                    g = Graphics.FromHwnd(intptr);
                }
                return g;
            }

            set
            {
                g = value;
            }
        }

        public void ReDisplay(Entities.Ground ground, Entities.Shape shape)
        {
            ground.DrawGround(G);
            shape.DrawShape(G);
        }
    }
}

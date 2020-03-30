using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussiaBlock.GameController
{
    class GameControl
    {
        IntPtr intptr;
        public GameControl(IntPtr intptr)
        {
            this.intptr = intptr;
        }
        public void StatrGame()
        {
            Entities.Ground ground = new Entities.Ground();
            Entities.Shape shape = new Entities.ShapeL();
            //View.GamePanel gp = new View.GamePanel(intptr);
            //gp.ReDisplay(ground, shape);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussiaBlock.Entities
{
    class ShapeL : Shape
    {
        //抽象类必须在子类中override，如果未被override，则也需要为抽象类
        public override void SetUnits()
        {
            Units[0].Position = new CellPositon() { RowIndex = 0, ColIndex = Util.CommonHelper.MidIndex };
            Units[1].Position = new CellPositon() { RowIndex = 1, ColIndex = Util.CommonHelper.MidIndex };
            Units[2].Position = new CellPositon() { RowIndex = 2, ColIndex = Util.CommonHelper.MidIndex };
            Units[3].Position = new CellPositon() { RowIndex = 2, ColIndex = Util.CommonHelper.MidIndex + 1 };
        }
    }
}

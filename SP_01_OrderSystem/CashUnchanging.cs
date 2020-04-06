using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_01_OrderSystem
{
    /// <summary>
    /// 金額不變
    /// </summary>
    class CashUnchanging : Cash
    {
        public override double cashCondition(double money)
        {
            return money;
        }
    }
}

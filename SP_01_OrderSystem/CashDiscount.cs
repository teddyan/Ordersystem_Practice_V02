using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_01_OrderSystem
{/// <summary>
/// Discount
/// </summary>
    class CashDiscount : Cash
    {
        private double moneyDiscount = 2d; //Set discount's digital

        public CashDiscount(double moneydiscount)
        {
            this.moneyDiscount = moneydiscount;
        }
        public override double cashCondition(double money)
        {
            return money * this.moneyDiscount;
        }
    }
}

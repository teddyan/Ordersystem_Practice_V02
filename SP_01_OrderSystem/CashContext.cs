using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_01_OrderSystem
{

    class CashContext
    {
        Cash cs = null;
     
        public enum Type
        {
            Feedback,
            Discount,
            Unchanging
        }
        public CashContext(Type type) //Cash Method
        {
            switch (type)
            {
                case Type.Discount:
                    CashDiscount cd = new CashDiscount(0.8);
                    cs = cd;
                    break;
                case Type.Feedback:
                    CashFeedback cf = new CashFeedback(300, 100);
                    cs = cf;
                    break;
                case Type.Unchanging:
                    CashUnchanging cu = new CashUnchanging();
                    cs = cu;
                    break;
            }
        }
        public double GetResult(double money)
        {
            return cs.cashCondition(money);
        }
    }
}

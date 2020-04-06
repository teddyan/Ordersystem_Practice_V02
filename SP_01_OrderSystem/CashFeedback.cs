using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_01_OrderSystem
{
    /// <summary>
    /// Feedback
    /// </summary>
    class CashFeedback : Cash
    {
        private int _moneySituation = 0;
        private int _moneyFeedback = 0;
        public CashFeedback() { }
        public CashFeedback(int moneySituation, int moneyFeedback)
        {
            this._moneyFeedback = moneyFeedback;
            this._moneySituation = moneySituation;
        }
        public int moneySituation
        {
            get { return _moneySituation; }
            set { _moneySituation = value; }
        }
        public int moneyFeedback
        {
            get { return _moneyFeedback; }
            set { _moneyFeedback = value; }
        }

        public override double cashCondition(double money)
        {
            double result = money;
            if (money >= moneySituation) //If match the criteria, will give you a discount, or the initial price
                result = money - Math.Floor(money / moneySituation) * _moneyFeedback; //  Floor is the greatest integer muitiple by feedback money =after money
            return result;


        }
    }
}

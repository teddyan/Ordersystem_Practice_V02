using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_01_OrderSystem
{
    /// <summary>
    /// Darling Harbour Restaurant
    /// 20% off today!!
    /// </summary>
    class RestaurantBranchesDarlingHarbour : Restaurant
    {
        private CashContext c = new CashContext(CashContext.Type.Discount);
        public RestaurantBranchesDarlingHarbour(string name) : base(name)
        {

        }
        public override void GetMenu(List<Menu> menu)
        {
            foreach (Menu mu in menu)
            {
                Console.WriteLine("The {0} menu today is\r\n Appetite :{1} \r\n 　Soup:{2}\r\n 　Dessert:{3}\r\n 　Main:{4} \r\nThe price before discount is:{5}，{6}\r\n", mu.Serial, mu.Appetizer, mu.Soup, mu.Dessert, mu.MainCourse, mu.Price, GetMoney(mu.Price));
            }
        }


        public override string GetMoney(double price)
        {
            double a = c.GetResult(price);
            return String.Format("Hey here is a discount!!{0},The price after discount is{1}\r\n", CashContext.Type.Discount, a);
        }
    }
}

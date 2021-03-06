﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_01_OrderSystem
{
    /// <summary>
    /// Bondi Junction Discount
    /// There is no Discount:(
    /// </summary>
    class RestaurantBranchesBondiJunction : Restaurant
    {
        private CashContext c = new CashContext(CashContext.Type.Unchanging);
        public RestaurantBranchesBondiJunction(string name) : base(name) { }
        //Override GetMenu 
        public override void GetMenu(List<Menu> menu)
        {
            foreach (Menu mu in menu)
            {
                Console.WriteLine("The {0} menu Today is\r\n Appetite:{1} \r\n 　Soup:{2}\r\n 　Dessert:{3}\r\n 　Main:{4} \r\nThe Price was:{5}，{6}\r\n", mu.Serial, mu.Appetizer, mu.Soup, mu.Dessert, mu.MainCourse, mu.Price, GetMoney(mu.Price));
            }

        }

        public override string GetMoney(double price)
        {
            double a = c.GetResult(price);
            return String.Format("Hey here is a discount!!{0},The price after discount is{1}\r\n", CashContext.Type.Unchanging, a);
        }
    }
}
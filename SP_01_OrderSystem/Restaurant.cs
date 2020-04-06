using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_01_OrderSystem
{
    /// <summary>
    /// Restaurant parent class
    /// </summary>
    abstract class Restaurant
    {
        protected string restaurantName;
        protected Restaurant(string name)
        {
            this.restaurantName = name;
        }
        public abstract void GetMenu(List<Menu> menu);

        public abstract string GetMoney(double price);

    }
}

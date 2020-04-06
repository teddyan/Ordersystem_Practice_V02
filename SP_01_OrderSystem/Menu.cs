using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_01_OrderSystem
{
    /// <summary>
    /// Menu
    /// </summary>
     class Menu
    {
        private int _Serial = 1;
        private string _Appetizer = "Butter Prawn";
        private string _Soup = "tomato pumpkin soup";
        private string _Dessert = "smashed red bea pancke";
        private string _MainCourse = "Spaghetti with Butter and Cheese";
        private double _Price = 49;
        public int Serial
        {
            get { return _Serial; }
            set { _Serial =value; }
        }
        public string Appetizer
        {
            get { return _Appetizer; }
            set
            { _Appetizer = value; }
        }
        public string Soup
        {
            get { return _Soup; }
            set
            { _Soup = value; }
        }
        public string Dessert
        {
            get { return _Dessert; }
            set
            { _Dessert = value; }
        }
        public string MainCourse
        {
            get { return _MainCourse; }
            set
            { _MainCourse = value; }
        }
        public double Price
        {
            get { return _Price; }
            set
            {
                _Price = value;
            }
        }
    }
}

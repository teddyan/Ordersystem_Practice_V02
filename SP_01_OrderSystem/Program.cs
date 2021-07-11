using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_01_OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            List<Menu> menu = new List<Menu>();
            Menu mu = new Menu();
            
            menu.Add(new Menu
            {
                Serial = mu.Serial,
                Appetizer = mu.Appetizer,
                Dessert = mu.Dessert,
                MainCourse = mu.MainCourse,
                Soup = mu.Soup,
                Price = mu.Price
            });
            int a = 0;
            int Chosen = 0; // The restaurant that user chosen
            bool keepLooping = false;
            bool chooseSuccess = false;
            while (keepLooping == false)
            {
                Console.WriteLine("Choose your identity:");
                Console.WriteLine("User:1 , Restaurant Backstage:2");
                chooseSuccess = int.TryParse((Console.ReadLine()), out a); //If success output a, or return the boolean value
                if (chooseSuccess == true && (a <= 2 && a > 0))
                {
                    Console.WriteLine("\r\n Choose Successfully \r\n");
                    Console.Clear();
                }

                switch (a.ToString())
                {
                    case "1":
                        Console.WriteLine("Which restaurant you want to go?");
                        Console.WriteLine("Parramatta:1 Darling Harbour:2 Bondi Junction:3\r\n");
                        Chosen = int.Parse(Console.ReadLine());
                        if (Chosen == 1)
                        {
                            Restaurant r1 = new RestaurantBranchesParramatta("Parramatta");
                            r1.GetMenu(menu);

                        }
                        else if (Chosen == 2)
                        {
                            Restaurant r2 = new RestaurantBranchesBondiJunction("Darling Harbour");
                            r2.GetMenu(menu);

                        }
                        else if (Chosen == 3)
                        {
                            Restaurant r3 = new RestaurantBranchesDarlingHarbour("Bondi Junction");
                            r3.GetMenu(menu);

                        }

                        else
                        {
                            Console.WriteLine("...If you have no choose just left....");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Hi this is backstage, what would you want to do today:) ?");
                        Console.WriteLine("1.Create a meanu 2.Check the current menu\r\n");
                        Chosen = int.Parse(Console.ReadLine());
                        if (Chosen == 1)
                        {
                            int serial = i;
                            Console.WriteLine("Create a new menu!!!");
                            Console.WriteLine("The appetizer is:");
                            string app = Console.ReadLine();
                            Console.WriteLine("The soup name is:");
                            string soup = Console.ReadLine();
                            Console.WriteLine("The dessert name is:");
                            string dessert = Console.ReadLine();
                            Console.WriteLine("What is your main dish name:");
                            string maincourse = Console.ReadLine();
                            Console.WriteLine("How much your customer gonna pay? :");
                            int price = int.Parse(Console.ReadLine());
                            Menu menu1 = new Menu()
                            {
                                Serial = serial,
                                Appetizer = app,
                                Soup = soup,
                                Dessert = dessert,
                                MainCourse = maincourse,
                                Price = price
                            };
                            menu.Add(menu1);
                            i++;
                            break;
                        }

                        else if (Chosen == 2)
                        {
                            foreach (var mus in menu)
                            {
                                Console.WriteLine(String.Format("The {0} menu is: \r\nThe appetite is {1} \r\n The soup is {2} \r\n the dessert is {3} \r\nThe main is {4} \r\n The price is {5} \r\n", mus.Serial, mus.Appetizer, mus.Soup, mus.Dessert, mus.MainCourse, mus.Price));
                            }
                            break;
                        }
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}



﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    public class DinerMenu : Menu
    {
            static int MAX_ITEMS = 6;
            int numberOfItems = 0;
            MenuItem[] menuItems;

            public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            addltem("Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);

            addltem("BLT", "Bacon with lettuce & tomato on whole wheat", 
                false, 2.99);

            addltem("Soup of the day",
                "Soup of the day, with a side of potato salad", false, 3.29);

            addltem("Hotdog",
                "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);

        }

        public void addltem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);

            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public Iterator createIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant 
{
    public class PancakeHouseMenu : Menu
    {
        private List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            addltem("K&B's Pancake Breakfast", 
                "Pancakes with scrambled eggs, and toast", true, 2.99);

            addltem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage",
                false, 2.99);

            addltem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries", true, 3.49);

            addltem("Waffles",
                "Waffles, with your choice of blueberries or strawberries", true, 3.49);
        }

        public void addltem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        public Iterator createIterator()
        {
            return new PancakeHouseIterator(menuItems);
        }
    }
}

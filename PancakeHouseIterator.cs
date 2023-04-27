using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant
{
    class PancakeHouseIterator : Iterator
    {
        List<MenuItem> items;
        int position = 0;
        public PancakeHouseIterator(List<MenuItem> items)
        {
            this.items = items;
        }
        public MenuItem next()
        {
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }
        public bool hasNext()
        {
            if (position >= items.Count || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
          }
        }
    }

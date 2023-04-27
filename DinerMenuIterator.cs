using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant
{
    public class DinerMenuIterator : Iterator
    {
        MenuItem[] items;
        int position = 0;
    public DinerMenuIterator(MenuItem[] items)
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
        if (position >= items.Length || items[position] == null)
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

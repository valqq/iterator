using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant
{
    public interface Menu
    {
        public Iterator createIterator();
    }
}

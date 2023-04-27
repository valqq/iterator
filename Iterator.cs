using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant
{
    public interface Iterator
    {
        bool hasNext();
        MenuItem next();
    }
}

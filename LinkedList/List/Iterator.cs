using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.List
{
    public interface Iterator<T>
    {

        bool hasNext();

        T next();

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.List
{
    interface List <G>
    {
        void add(G data);

        G get(int index);

        void delete(int index);

        int getSize();

        Iterator<G> getIterator();

        Iterator<G> getReverseIterator();

        void insert(G data, Position position, Iterator<G> it);
    }
}

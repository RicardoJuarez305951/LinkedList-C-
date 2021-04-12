using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.List
{
    public class ArrayList<H> : List<H>{

    public static Object[] array;
    public static int size;

    public ArrayList()
    {
        array = new Object[2];
    }

    
    public void add(H data)
    {
        if (array.Length <= size)
        {
            Object[] arrayN = new Object[array.Length + 2];
            Array.Copy(array, 0, arrayN, 0, array.Length);
            array = arrayN;
        }
        array[size] = data;
        size++;
    }

    
    public H get(int index)
    {
        return (H)array[index];
    }

    
    public void delete(int index)
    {
        if (index < 0 && index >= size)
        {
            return;
        }
        else
        {

            for (int currentIndex = index + 1; currentIndex < size; currentIndex++)
            {
                array[currentIndex - 1] = array[currentIndex];
            }
            size--;
        }
    }

    
    public void insert(H data, Position position, Iterator<H> it)
    {
    }


    public class ForwardIterator : Iterator<H> {
            private int currentIndex;
            public bool hasNext()
            {
                return currentIndex < size;
            }
            public H next()
            {
                return (H)array[currentIndex++];
            }
        }
        public class ReverseIterator : Iterator<H> {
            private int currentIndex;
            public ReverseIterator()
            {
                currentIndex = size - 1;
            }
            public bool hasNext()
            {
                return currentIndex > 0;
            }
            public H next()
            {
                return (H)array[currentIndex--];
            }
        }
        public Iterator<H> getIterator(){
            return new ForwardIterator();
        }
        public int getSize(){
            return size;
        }
        /*
        public ReverseIterator getReverseIterator()
        {
            return new ReverseIterator();
        }*/

        Iterator<H> List<H>.getReverseIterator()
        {
            return new ReverseIterator();
        }
    }
}

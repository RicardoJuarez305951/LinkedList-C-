using LinkedList.List;

using System;

class programa
{

    static void Main(String[] args)
    {

        List<int> lista1 = new ArrayList<int>();
        List<String> lista2 = new ArrayList<String>();

        lista1.add(1);
        lista1.add(4);
        lista1.add(3);
        lista1.add(7);

        lista2.add("hola");
        lista2.add(" Object ");
        lista2.add(" Oriented ");
        lista2.add(" Programming ");

        lista1.delete(3);

        System.Console.WriteLine("---------------------");

        System.Console.WriteLine("El tamaño es:" + lista1.getSize());

        Iterator<int> it = lista1.getIterator();

        while (it.hasNext())
        {
            int element = it.next();

            System.Console.WriteLine("Dato: " + element);
        }



        System.Console.WriteLine("---------------------");

        it = lista1.getReverseIterator();

        while (it.hasNext())
        {
            int element = it.next();

            System.Console.WriteLine("Dato: " + element);
        }

        System.Console.WriteLine("---------------------");

        Iterator<String> itStrings = lista2.getIterator();

        while (itStrings.hasNext())
        {
            System.Console.WriteLine(itStrings.next());
        }

    }
}
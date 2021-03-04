using System;
using System.Collections.Generic;
using System.Text;

public class ReverseIterator
{

    private Node currentNode;

    public ReverseIterator(Node currentNode)
    {
        this.currentNode = currentNode;
    }

    public ReverseIterator(ReverseIterator iterator)
    {
        currentNode = iterator.currentNode;
    }

    public bool hasNext()
    {
        return currentNode != null;
    }

    public int previous()
    {
        int data = currentNode.getData();

        currentNode = currentNode.getPrevious();

        return data;
    }

    Node getCurrentNode()
    {  // modificador de acceso se llama -> package-private
        return currentNode;
    }

    public int next()
    {
        int data = currentNode.getData();

        currentNode = currentNode.getPrevious();

        return data;
    }
}
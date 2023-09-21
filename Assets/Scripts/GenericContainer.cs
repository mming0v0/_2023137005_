using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainer<T>
{

    private T[] items;
    private int currentlndex = 0;

    public GenericContainer(int capacity)
    {
        items = new T[capacity];
    }

    public void Add(T item)
    {
        if(currentlndex < items.Length)
        {
            items[currentlndex] = item;
            currentlndex++;
        }
    }

    public T[] Getltems()
    {
        return items;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedSizeLIst<T>
{
    private LinkedList<T> list =  new LinkedList<T>();
    public int Limit { get; }

    public LimitedSizeLIst(int limit)
    {
        Limit = limit;
    }
        
    public void Add(T item)
    {
        if(list.Count+1>Limit)
            list.RemoveFirst();
        list.AddLast(item);
    }

    public void Remove(T item)
    {
        list.Remove(item);
    }

    public bool Contains(T item) => list.Contains(item);
    public int Count() => list.Count;
}

using System;
using System.Collections.Generic;
using System.Linq;

public class GenericClass<T> where T : struct
{
    private List<T> _collection;

    public GenericClass()
    {
        _collection = new List<T>();
    }

    public void AddItem(T item)
    {
        _collection.Add(item);
    }

    public T GetItem(int index)
    {
        if (index < 0 || index >= _collection.Count)
        {
            throw new ArgumentOutOfRangeException("Index out of range");
        }

        return _collection[index];
    }

    public IEnumerable<T> GetSortedDescending()
    {
        return _collection.OrderByDescending(item => item);
    }
}

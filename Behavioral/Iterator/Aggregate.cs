﻿using Iterator.Interfaces;

namespace Iterator;

public class Aggregate : IAggregate
{
    private List<string> _collection;

    public Aggregate()
    {
        _collection = new List<string>();
    }
    
    public IIterator GetIterator()
    {
        return new Iterator(this);
    }

    public string this[int index] 
    { 
        get 
        {
            if (index < _collection.Count)
                return _collection[index];

            return string.Empty;
        }
        set 
        {
            _collection.Add(value);
        }
    }

    public int Limit => _collection.Count;

}

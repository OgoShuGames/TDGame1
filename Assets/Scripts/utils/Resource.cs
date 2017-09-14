using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource<T> : ScriptableObject where T : UnityEngine.Object
{
    T obj;
    string path;

    public Resource(string path)
    {
        this.path = path;
    }

    public T get()
    {
        if (obj == null)
            obj = Resources.Load(path) as T;
        return obj;
    }

    public void free()
    {
        obj = null;
    }
}

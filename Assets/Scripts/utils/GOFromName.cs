using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOFromName : ScriptableObject
{
    GameObject obj;
    string path;

    public GOFromName(string path)
    {
        this.path = path;
    }

    public GameObject get()
    {
        if (obj == null)
            obj = GameObject.Find(path);
        return obj;
    }

    public void free()
    {
        obj = null;
    }
}

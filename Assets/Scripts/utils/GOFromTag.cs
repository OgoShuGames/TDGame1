using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOFromTag : ScriptableObject
{
    GameObject obj;
    string path;

    public GOFromTag(string path)
    {
        this.path = path;
    }

    public GameObject get()
    {
        if (obj == null)
            obj = GameObject.FindGameObjectWithTag(path);
        return obj;
    }

    public void free()
    {
        obj = null;
    }
}

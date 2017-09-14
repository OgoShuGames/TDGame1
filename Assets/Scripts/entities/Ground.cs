using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public static Ground instance;
    public static Collider coll;

    void Awake()
    {
        if (instance != null)
            throw new System.Exception("ground already exists");
        instance = this;
        coll = GetComponent<Collider>();
        if (coll == null)
            throw new System.Exception("ground must have collider");
    }
}

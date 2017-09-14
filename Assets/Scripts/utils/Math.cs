using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Math
{
    public static Vector3 Round(this Vector3 v)
    {
        return new Vector3(Mathf.Round(v.x), Mathf.Round(v.y), Mathf.Round(v.z));
    }
}

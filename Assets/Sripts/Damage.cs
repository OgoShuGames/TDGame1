using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public enum Type
    {
        explosive,
        kinetic,
        magic
    };
    
    [SerializeField]
    Type dmgType;
    [SerializeField]
    float dmg;

    public void Hit(Health H)
    {
        H.GetDmg(dmg, dmgType); 
    }
}

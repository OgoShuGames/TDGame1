using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shot : MonoBehaviour
{
    public abstract void Shoot(Damage shooter, Health victim);
}

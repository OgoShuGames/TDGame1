using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantShot : Shot
{
    public override void Shoot(Damage shooter, Health victim)
    {
        shooter.Hit(victim);
    }
}

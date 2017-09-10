using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAI : MonoBehaviour
{
    [SerializeField]
    ChooseVictim chooser;
    [SerializeField]
    LookAtTarget looker;
    [SerializeField]
    Shot shooter;
    [SerializeField]
    Damage damager;
    [SerializeField]
    float reloadTime;

    float angleTollerance;
    float reloadTimer;
    float angle;
    bool aimed;
    bool reloaded;

    public void FixedUpdate()
    {
        reloaded = ((reloadTimer -= Time.fixedDeltaTime) <= 0);
        aimed = (chooser.victim != null && looker.LookAt(chooser.victim.transform) < angleTollerance);
        if (aimed && reloaded)
        {
            shooter.Shoot(damager, chooser.victim.GetComponent<DamageController>());
            reloadTimer = reloadTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseVictim : MonoBehaviour
{
    public BelongTo victim { get; private set; }
    [SerializeField]
    List<BelongTo> potentialVictim = new List<BelongTo>();
    BelongTo newCandidate;
    List<Faction> enemyFactions;

    private void OnTriggerEnter(Collider other)
    {
        newCandidate = other.GetComponent<BelongTo>();
        if (newCandidate != null && (enemyFactions.Contains(newCandidate.faction)))
        {
            potentialVictim.Add(newCandidate);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        newCandidate = other.GetComponent<BelongTo>();
        if (newCandidate != null)
        {
            potentialVictim.Remove(newCandidate);
            if(newCandidate == victim)
            {
                Choose();
            }
        }
    }

    public void Choose()
    {
        while (victim == null && potentialVictim.Count > 0)
        {
            victim = potentialVictim[0];
            if(victim == null)
                potentialVictim.RemoveAt(0);
        }
        if (potentialVictim.Count > 0)
        {
            for (int i = 1; i < potentialVictim.Count; i++)
            {
                if(potentialVictim[i] == null)
                {
                    potentialVictim.RemoveAt(i--);
                } else if ((victim.transform.position - transform.position).sqrMagnitude >
                    (potentialVictim[i].transform.position - transform.position).sqrMagnitude)
                {
                    victim = potentialVictim[i];
                }
            }
        }
        else
        {
            victim = null;
        }
    }

    private void FixedUpdate()
    {
        if(victim == null)
        {
            Choose();
        }
    }

    private void Start()
    {
        enemyFactions = GetComponentInParent<BelongTo>().faction.enemies;
    }
}

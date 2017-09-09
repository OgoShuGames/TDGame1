using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    public List<Transform> path;

    private void OnTriggerEnter(Collider other)
    {
        var walker = other.GetComponent<WalkAlongTheRoad>();
        if (walker != null)
        {
            walker.SetHome(this);
        }
    }
}

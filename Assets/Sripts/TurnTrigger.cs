using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var walker = other.GetComponent<WalkAlongTheRoad>();
        if (walker != null && walker.target == transform)
        {
            walker.NextPathPoint();
        }
    }
}

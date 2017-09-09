using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAvoidance : MonoBehaviour {
    public float repellAcceleration;
    Vector3 radius;
    Vector2 random;
    private void OnTriggerStay(Collider other)
    {
        if(other.transform != transform.parent)
        {
            var walker = other.GetComponent<WalkAlongTheRoad>();
            if (walker != null)
            {
                radius = (transform.position - other.transform.position);
                if(radius == Vector3.zero)
                {
                    random = Random.insideUnitCircle;
                    radius = new Vector3(random.x, 0, random.y);
                    
                }
                walker.ApplyAcceleration((repellAcceleration / (radius.sqrMagnitude*radius.magnitude)) * radius);
            }
        }
    }
}

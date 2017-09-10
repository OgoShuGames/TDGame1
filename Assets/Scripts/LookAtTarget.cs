using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    [SerializeField]
    float angularSpeed = 90;
    Quaternion lookAtTarget;

    public float LookAt(Transform target)
    {
        if(target != null)
        {
            lookAtTarget = Quaternion.LookRotation(target.position - transform.position);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, lookAtTarget, angularSpeed * Time.fixedDeltaTime);
            return Quaternion.Angle(lookAtTarget, transform.rotation);
        }
        return 0;
    }
}

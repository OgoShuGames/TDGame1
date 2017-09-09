using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAlongTheRoad : MonoBehaviour {

    public Transform target { get; private set; }

    [SerializeField]
    float forceMagnitude;
    [SerializeField]
    SpawnTrigger home;

    int pathIndex = -1;
    Vector3 force;
    Rigidbody rigBody;
     
	// Use this for initialization
	void Start ()
    {
        rigBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (target != null)
        {
            force = (target.position - transform.position).normalized * forceMagnitude;
            ApplyAcceleration(force);
        }
	}

    public void NextPathPoint()
    {
        pathIndex++;
        target = home.path[pathIndex];
    }

    public void ApplyAcceleration(Vector3 accel)
    {
        rigBody.AddForce(accel*Time.timeScale);  
    }

    public void SetHome(SpawnTrigger newHome)
    {
        if (home == null)
        {
            home = newHome;
            NextPathPoint();
        }
    }
}

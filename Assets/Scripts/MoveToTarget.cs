using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget: MonoBehaviour 
{

    public Transform target;
	public float speed = 10;

    void Update()
    {
		MoveTowardsTarget();
		RotateTowardsTarget();

	}

	void MoveTowardsTarget()
	{

			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);

	}

	void RotateTowardsTarget()
	{
		transform.up = target.position - transform.position;
	}
}

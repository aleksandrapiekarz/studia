using UnityEngine;
using System.Collections;

public class EnemyAI : Player {
	private Transform target;
	public int moveSpeed;
	public int rotationSpeed;

	public Transform Target
	{
		get{
			return target;
		}


		set {


			target = value;
		}



	}



	void Start () {
		
	}

	// Update is called once per frame
	void Update () { 

		FollowTarget ();

	}


	private void FollowTarget()
	{
		if (target != null) {

			transform.position=Vector2.MoveTowards(transform.position, target.position, 1*Time.deltaTime);

		}


	



			}

}
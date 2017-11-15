using UnityEngine;
using System.Collections;

public class PHomingProj : MonoBehaviour {

	private GameObject home;
	public float torqueforce;

	private GameObject HomeOn()
	{
		GameObject[] targets;
		targets = GameObject.FindGameObjectsWithTag ("Enemy");
		float distance = Mathf.Infinity;
		float angle;
		GameObject home = null;
		Vector3 position = transform.position;
		foreach (GameObject target in targets)
		{
			angle = Vector3.Angle(transform.forward, target.transform.position - position);
			if(angle <= 45)
			{
				Vector3 between = target.transform.position - position;
				float curdistance = between.sqrMagnitude;
				if(curdistance < distance)
				{
					home = target;
					distance = curdistance;
				}
			}
		}
		return home;
	}
	void Homing (GameObject target)
	{
		//Get the line from position to target.
		Vector3 between = target.transform.position - transform.position;
		//Get the angle between straight ahead and target.
		float angle = Vector3.Angle (transform.forward, between);
		//???
		Vector3 crossprod = Vector3.Cross (transform.forward, between);
		GetComponent<Rigidbody>().AddTorque (crossprod * angle * torqueforce);
		GetComponent<Rigidbody>().velocity = transform.forward * Vector3.Dot(transform.forward, GetComponent<Rigidbody>().velocity);
	}
	// Use this for initialization
	void Start () {
		home = HomeOn ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (home != null) {
			Homing (home);
		}
	}
}

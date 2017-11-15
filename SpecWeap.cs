using UnityEngine;
using System.Collections;

public class SpecWeap : MonoBehaviour {

	public int ammo;
	public int maxammo;
	public int ammocost;
	public Transform weapbay;
	public float firerate;
	public float deltashot;
	public float force;

	public virtual void Shoot(Rigidbody spec)
	{
		if (deltashot >= firerate && ammo > 0) 
		{
			Rigidbody specproj;
			specproj = Instantiate(spec, weapbay.position, weapbay.rotation) as Rigidbody;
			specproj.AddForce(transform.forward * force);
			ammo -= ammocost;
			deltashot = 0;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

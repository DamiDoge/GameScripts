using UnityEngine;
using System.Collections;

public class SemiAuto : EGun {
	

	public override void Shoot (Rigidbody EProj)
	{
		base.Shoot (EProj);
	}

	// Use this for initialization
	void Start () {
		force = 1;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") == true)
				Shoot (EProj);
	
	}
}

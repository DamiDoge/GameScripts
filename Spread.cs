using UnityEngine;
using System.Collections;

public class Spread : EGun {

	private float random_v = 0;
	private float random_h = 0;


	public override void Shoot (Rigidbody EProj)
	{
		if (DeltaShot >= FireRate && Energy - EnergyCost >= 0) {
			Energy -= EnergyCost;
			for (int i = 0; i <= 4; i++) {
				random_h = Random.Range (-10, 10);
				random_v = Random.Range (-10, 10);
				random_h = Random.Range (-10, 10);
				random_v = Random.Range (-10, 10);
				Rigidbody Proj_1;
				Rigidbody Proj_2;
				Proj_1 = Instantiate (EProj, left.transform.position, left.transform.rotation) as Rigidbody;
				Proj_1.transform.Rotate (random_h, random_v, 0);
				Proj_1.AddForce (Proj_1.transform.forward * force);
				Proj_2 = Instantiate (EProj, right.transform.position, right.transform.rotation) as Rigidbody;
				Proj_2.transform.Rotate (random_h, random_v, 0);
				Proj_2.AddForce (Proj_2.transform.forward * force);
			}
			Debug.Log (Energy);
			DeltaShot = 0;
			}
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

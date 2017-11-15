using UnityEngine;
using System.Collections;

public class Turret : Enemy {

	public GameObject player;
	public Rigidbody TurProj;
	public float range;
	public float Tfirerate;
	private float dtime;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
		dtime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		dtime += Time.deltaTime;
		if (inRange (player.transform, range) == true)
		{
			if(dtime >= Tfirerate)
			{
				Shoot (TurProj, gun);
				dtime = 0;
			}
		}
		IsDead (block);
	}
}

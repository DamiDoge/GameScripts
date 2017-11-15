using UnityEngine;
using System.Collections;

public class Byte : Player {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Hit += Time.deltaTime;
		RechargeShield ();
		movement ();
	}
}

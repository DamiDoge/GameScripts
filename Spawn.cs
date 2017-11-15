using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject PlayerShip;

	void SpawnPlayer(GameObject PlayerShip)
	{
		Instantiate (PlayerShip);
	}

	// Use this for initialization
	void Start () {
		SpawnPlayer (PlayerShip);
	
	}
	
	// Update is called once per frame
	void Update () {
	}
}

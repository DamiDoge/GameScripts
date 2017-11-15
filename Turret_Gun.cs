using UnityEngine;
using System.Collections;

public class Turret_Gun : MonoBehaviour {

	public GameObject player;
	Transform PlayerPos;
	public void HitDamage(float damage)
	{
		this.transform.parent.GetComponent<Turret>().Shield -= damage;
		Debug.Log (damage);
	}
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(player != null)
			transform.LookAt (player.transform);
	}
}

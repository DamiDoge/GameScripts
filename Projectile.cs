using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public int damage;

	public void OnCollisionEnter(Collision collision)
	{
		collision.gameObject.SendMessage("HitDamage", damage, SendMessageOptions.DontRequireReceiver);
		Destroy (this.gameObject);
	}
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 9);
	}
	
	// Update is called once per frame
	void Update () {
	}
}

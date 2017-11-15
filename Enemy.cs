using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float Shield;
	public Transform gun;
	public GameObject block;

	public bool inRange(Transform playerPos, float Range)
	{
		if (Vector3.Distance (transform.position, playerPos.position) < Range)
		{
			return true;
		} 
		else
			return false;
	}
	public void Shoot(Rigidbody proj, Transform gun)
	{
		Rigidbody EPInstance = proj;
		EPInstance = Instantiate (proj, gun.position, gun.rotation) as Rigidbody;
		EPInstance.AddForce (gun.forward * 1);
		Physics.IgnoreCollision (EPInstance.GetComponent<Collider>(), this.GetComponent<Collider>());
	}
	public void HitDamage(float damage)
	{
		Shield -= damage;
		Debug.Log (damage);
	}
	public void IsDead(GameObject block)
	{
		if (Shield <= 0) {
			for(int i = 0; i <= 5; i++)
			{
				Vector3 Codeposition = this.transform.position;
				Codeposition[2] += Random.Range(-0.5f,0.5f);
				Instantiate(block, Codeposition, transform.rotation);
			}
			Destroy(this.gameObject);
		}
	}
	public void TargetPlayer(Transform playerPos)
	{
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

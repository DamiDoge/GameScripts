using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed;
	public float rollspeed;
	public float pitchspeed;
	public float shield;
	public float shieldRechargeRate;
	public float shieldRechargeDelay;
	public float MaxShield;
	protected float Hit; //Used to count time since last hit.

	public void RechargeShield()
	{
		if (Hit >= shieldRechargeDelay && shield < MaxShield) 
		{
			if (shield + (shieldRechargeRate * Time.deltaTime) > MaxShield) 
			{
						shield = MaxShield;
			} 
			else 
			{
						shield += (shieldRechargeRate * Time.deltaTime);
			}
			Debug.Log (shield);
		}
	}

	public void HitDamage(float damage)
	{
		shield -= damage;
		Debug.Log (shield);
		Hit = 0;
	}
	
	public void movement ()
	{
		float forward = Input.GetAxis ("Jump") * speed * Time.deltaTime;
		float roll = Input.GetAxis ("Horizontal") * rollspeed * Time.deltaTime;
		float pitch = Input.GetAxis ("Vertical") * pitchspeed * Time.deltaTime;
		
		transform.Translate (Vector3.forward * forward);
		transform.Rotate (Vector3.forward * roll);
		transform.Rotate (Vector3.right * pitch);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
}

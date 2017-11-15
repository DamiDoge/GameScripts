using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EGun : MonoBehaviour {

	public Transform left;
	public Transform right;
	public float EnergyCost;
	public float FireRate;
	public Rigidbody EProj;
	public float force;
	static public float Energy = 100;
	static private float MaxEnergy = 100;
	static public float ECharge = 15;
	static public float EDelay = 3;
	static public float DeltaShot = 0; //Count time since last shot.

	private SemiAuto semiauto;
	private Spread spread;
	private FullAuto fullauto;
	private GunHoming homing;
	public virtual void Shoot(Rigidbody EProj)
	{
		if (DeltaShot >= FireRate && Energy - EnergyCost >= 0) {
					Rigidbody EInstance;
					EInstance = Instantiate (EProj, left.transform.position, left.transform.rotation) as Rigidbody;
					EInstance.AddForce (transform.forward * force);
					EInstance = Instantiate (EProj, right.transform.position, right.transform.rotation) as Rigidbody;
					EInstance.AddForce (transform.forward * force);
					Energy -= EnergyCost;
					DeltaShot = 0;
				}
	}
	public void ChargeGun ()
	{
		if (DeltaShot >= EDelay && Energy < MaxEnergy) 
		{
			if (Energy + (ECharge * Time.deltaTime) > MaxEnergy)
				Energy = MaxEnergy;
			else
				Energy += ECharge * Time.deltaTime;
		}
			
	}

	public float ReadMaxEnergy()
	{
		return (float)MaxEnergy;
	}
	public float ReadEnergy()
	{
		return (float)Energy;
	}

	public void equiped_gun ()
	{
		if (Input.GetKeyDown (KeyCode.Alpha1) == true) {
			semiauto.enabled = true;
			spread.enabled = false;
			fullauto.enabled = false;
			homing.enabled = false;
		}
		if (Input.GetKeyDown(KeyCode.Alpha2) == true) {
			semiauto.enabled = false;
			spread.enabled = true;
			fullauto.enabled = false;
			homing.enabled = false;
		}
		if (Input.GetKeyDown(KeyCode.Alpha3) == true) {
			semiauto.enabled = false;
			spread.enabled = false;
			fullauto.enabled = true;
			homing.enabled = false;
		}
		if (Input.GetKeyDown(KeyCode.Alpha4) == true) {
			semiauto.enabled = false;
			spread.enabled = false;
			fullauto.enabled = false;
			homing.enabled = true;
		}
	}
	// Use this for initialization
	void Start () {
		Energy = 100;
		semiauto = GetComponent<SemiAuto>();
		spread = GetComponent<Spread>();
		fullauto = GetComponent<FullAuto>();
		homing = GetComponent<GunHoming>();
		semiauto.enabled = true;
		spread.enabled = false;
		fullauto.enabled = false;
		homing.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		DeltaShot += Time.deltaTime;
		ChargeGun ();
		equiped_gun ();
	}
}

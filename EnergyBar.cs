using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour {

	private float CurEnergy;
	private float MaxEnergy;
	public GameObject CurPlayer;
	public EGun PlayerEgun;
	Image Ebar;
	// Use this for initialization
	void Start () {
		Ebar = GetComponent<Image> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (CurPlayer == null) {
						CurPlayer = GameObject.FindWithTag ("Player");
						PlayerEgun = CurPlayer.GetComponent<EGun> ();
						CurEnergy = PlayerEgun.ReadEnergy ();
						MaxEnergy = PlayerEgun.ReadMaxEnergy ();
				} else {
						CurEnergy = PlayerEgun.ReadEnergy ();
						Ebar.fillAmount = CurEnergy / MaxEnergy;
				}
	}
}

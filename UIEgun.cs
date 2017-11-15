using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIEgun : MonoBehaviour {

	public Image StandardUI;
	public Image SpreadUI;
	public Image AutoUI;
	public Image HomingUI;

	private Image LastEquip;
	private GameObject CurPlayer;

	// Use this for initialization
	void Start () {
		LastEquip = StandardUI;
		StandardUI.enabled = false;
		SpreadUI.enabled = false;
		AutoUI.enabled = false;
		HomingUI.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (CurPlayer == null) {
						CurPlayer = GameObject.FindWithTag ("Player");
				} else {
						if (CurPlayer.GetComponent<SemiAuto> ().enabled == true) {
								LastEquip.enabled = false;
								StandardUI.enabled = true;
								LastEquip = StandardUI;
						}
						if (CurPlayer.GetComponent<Spread> ().enabled == true) {
								LastEquip.enabled = false;
								SpreadUI.enabled = true;
								LastEquip = SpreadUI;
						}
						if (CurPlayer.GetComponent<FullAuto> ().enabled == true) {
								LastEquip.enabled = false;
								AutoUI.enabled = true;
								LastEquip = AutoUI;
						}
						if (CurPlayer.GetComponent<GunHoming> ().enabled == true) {
								LastEquip.enabled = false;
								HomingUI.enabled = true;
								LastEquip = HomingUI;
						}
				}
	}
}

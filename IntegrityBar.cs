using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IntegrityBar : MonoBehaviour {

	private float CurShield;
	private float MaxShield;
	public GameObject CurPlayer;
	public Player player;
	Image Ibar;
	// Use this for initialization
	void Start () {
		Ibar = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (CurPlayer == null) {
			CurPlayer = GameObject.FindWithTag ("Player");
			player = CurPlayer.GetComponent<Player> ();
			CurShield = player.shield;
			MaxShield = player.MaxShield;
		} else {
			CurShield = player.shield;
			Ibar.fillAmount = CurShield / MaxShield;
		}
	}
}

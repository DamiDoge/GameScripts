using UnityEngine;
using System.Collections;

public class Shrink : MonoBehaviour {

	float scaledown;

	// Use this for initialization
	void Start () {
		scaledown = Random.Range (0.3f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localScale.x > 0)
		{
				transform.localScale -= new Vector3(scaledown * Time.deltaTime, scaledown * Time.deltaTime, scaledown * Time.deltaTime);
		}
		else 
		{
				Transform.Destroy (this.gameObject);
		}
	}
}
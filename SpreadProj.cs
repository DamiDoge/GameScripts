using UnityEngine;
using System.Collections;

public class SpreadProj : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float x = Random.Range (-10, 10);
		float y = Random.Range (-10, 10);
		transform.Rotate(Vector3.up, x);
		transform.Rotate(Vector3.right, y);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

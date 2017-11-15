using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;
	public float rollspeed;
	public float pitchspeed;

	void movement ()
	{
		float forward = Input.GetAxis ("Jump") * speed * Time.deltaTime;
		float roll = Input.GetAxis ("Horizontal") * rollspeed * Time.deltaTime;
		float pitch = Input.GetAxis ("Vertical") * pitchspeed * Time.deltaTime;

		transform.Translate (Vector3.forward * forward);
		transform.Rotate (Vector3.forward * roll);
		transform.Rotate (Vector3.right * pitch);
	}


	// Update is called once per frame
	void Update () {
		movement ();
	}
}

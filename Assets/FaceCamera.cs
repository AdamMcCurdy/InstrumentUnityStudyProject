using UnityEngine;
using System.Collections;

public class FaceCamera : MonoBehaviour {
	public float PlayerSpeed = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {		
		var relative = transform.position - Camera.main.transform.position;
//		relative.y = 0;
		Quaternion newRot = Quaternion.LookRotation (relative);
		transform.rotation = Quaternion.Slerp (transform.rotation, newRot, PlayerSpeed * Time.deltaTime);
	}

	void FixedUpdate() {
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (new Vector3(0, 0, PlayerSpeed) * Time.deltaTime, Space.World);
		}
		else if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (new Vector3(0, 0, -PlayerSpeed) * Time.deltaTime, Space.World);
		}

		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (new Vector3(-PlayerSpeed, 0, 0) * Time.deltaTime, Space.World);
		}
		else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (new Vector3(PlayerSpeed, 0, 0) * Time.deltaTime, Space.World);
		}
	}
}

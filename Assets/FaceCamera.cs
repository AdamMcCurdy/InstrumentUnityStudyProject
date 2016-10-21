using UnityEngine;
using System.Collections;

public class FaceCamera : MonoBehaviour {
	public float PlayerSpeed = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {		
		Vector3 camGroundPos = new Vector3 (
               Camera.main.transform.position.x,
			   Camera.main.transform.position.y,
               Camera.main.transform.position.z	
        );
			
		var relative = transform.position - camGroundPos;
//		relative.y = 0;
		Quaternion newRot = Quaternion.LookRotation (relative);
		transform.rotation = Quaternion.Slerp (transform.rotation, newRot, PlayerSpeed * Time.deltaTime);
	}

	void FixedUpdate() {		
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
//			transform.Translate (new Vector3(-PlayerSpeed, 0, PlayerSpeed) * Time.deltaTime, Space.World);
			GetComponent<Rigidbody>().AddForce(new Vector3(-PlayerSpeed, 0, PlayerSpeed));
		} else if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
//			transform.Translate (new Vector3(PlayerSpeed, 0, -PlayerSpeed) * Time.deltaTime, Space.World);
			GetComponent<Rigidbody>().AddForce(new Vector3(PlayerSpeed, 0, -PlayerSpeed));
		}

		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
//			transform.Translate (new Vector3(-PlayerSpeed, 0, -PlayerSpeed) * Time.deltaTime, Space.World);
			GetComponent<Rigidbody> ().AddForce (new Vector3 (-PlayerSpeed, 0, -PlayerSpeed));
		} else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
//			transform.Translate (new Vector3(PlayerSpeed, 0, PlayerSpeed) * Time.deltaTime, Space.World);
			GetComponent<Rigidbody> ().AddForce (new Vector3 (PlayerSpeed, 0, PlayerSpeed));
		}

//		if (Input.GetKey (KeyCode.None)) {
//			
//		}
	}
}

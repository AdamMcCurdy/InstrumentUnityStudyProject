using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	Vector3 offset = Vector3.zero;
	GameObject player;

	public float speed = 2f;

//	float turnValue = 0;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (
			transform.position, 
			player.transform.position + offset, 
			Time.deltaTime * speed
		);							
//		if (Input.GetKey (KeyCode.RightArrow)) {
//			turnValue += .1f;
//		} else if (Input.GetKey (KeyCode.LeftArrow)) {
//			turnValue -= .1f;
//		} else {
//			turnValue = Mathf.Lerp (turnValue, 0, Time.deltaTime);
//		}
//
//		Vector3 curRot = transform.eulerAngles;
//		Quaternion newRot = Quaternion.Euler(curRot + new Vector3 (0, turnValue, 0));
//
//		transform.rotation = Quaternion.Slerp (
//			transform.rotation,
//			newRot,
//			Time.deltaTime * 5f//arbitrary speed
//		);
	}
}

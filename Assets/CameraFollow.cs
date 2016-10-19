using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	Vector3 offset = Vector3.zero;
	GameObject player;

	public float speed = 2f;

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
	}
}

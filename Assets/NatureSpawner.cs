using UnityEngine;
using System.Collections;

public class NatureSpawner : MonoBehaviour {
	public GameObject[] items;

	[Range(2f, 10.0f)]
	public int offset = 2;

	public int gridSquare = 100;
	// Use this for initialization
	void Start () {
		for(var y = 1; y < gridSquare; y++) {
			if (y % Random.Range(offset, 11) == 0) {
				for(var x = 1; x < gridSquare; x++){
					if (x % Random.Range(offset, 11) == 0) {
						int randItem = Random.Range (0, items.Length);
						GameObject go = Instantiate (items[randItem], new Vector3 (x, 0, y), Quaternion.Euler(0, Random.Range(0, 360), 0)) as GameObject;
					}
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

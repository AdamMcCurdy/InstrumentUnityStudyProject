using UnityEngine;
using System.Collections;

public class TileSpawner : MonoBehaviour {
	public Sprite[] FloorSprites;
	public int gridSqaure = 50;
	// Use this for initialization
	void Start () {
		Vector3 tilepos = Vector3.zero;
		for(var y = 0; y < gridSqaure; y++) {
			for(var x = 0; x < gridSqaure; x++){
				GameObject go = Instantiate (Resources.Load ("Tile"), new Vector3 (x, 0, y), Quaternion.Euler(90, 0, 0)) as GameObject;
				int spriteNum = Random.Range (0, FloorSprites.Length);
				go.GetComponent<SpriteRenderer> ().sprite = FloorSprites[spriteNum];
				go.transform.parent = GameObject.Find ("Spawner").transform;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

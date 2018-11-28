using UnityEngine;
using System.Collections;

public class kingofsea : MonoBehaviour {

	public static kingofsea instance = null;
	public bool canSpawn;

	// Use this for initialization
	void Start () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		canSpawn = true;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] j = GameObject.FindGameObjectsWithTag ("rock");
		GameObject[] a = GameObject.FindGameObjectsWithTag ("spawner");
		int rocksOnScreen = j.Length;
		if (rocksOnScreen >= 3) {
			for (int i = 0; i < a.Length; i++) {
				Spawner c = a [i].GetComponent<Spawner> ();
				c.canSpawn = false;
			}
		} else {
			for (int i = 0; i < a.Length; i++) {
				Spawner c = a [i].GetComponent<Spawner> ();
				c.canSpawn = true;
			}
		}
	}
}

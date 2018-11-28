using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject spawnItem;
	public int max;
	public int min;
	int countDown;
	public bool canSpawn;

	void Awake() {
		countDown = Random.Range (min, max);
		canSpawn = true;
	}
	// Update is called once per frame
	void Update () {
		countDown--;
		if (countDown == 0 && canSpawn == true) {
			Instantiate (spawnItem, this.transform.position, this.transform.rotation);

			countDown = Random.Range(min, max);
		}
	}
}

using UnityEngine;
using System.Collections;

public class spawn3dEnemies : MonoBehaviour {

	int wait;
	public int minWait;
	public int maxWait;

	public GameObject enemy;

	void Start()
	{
		wait = 1;
	}

	// Update is called once per frame
	void Update () 
	{
		wait--;
		if (wait == 0) 
		{
			Instantiate (enemy, transform.position, transform.rotation);
			wait = Random.Range (minWait, maxWait);
		}
	}
}

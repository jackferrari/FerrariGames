using UnityEngine;
using System.Collections;

public class SpawnPowerUps : MonoBehaviour {

	public GameObject powerup;
	public int wait;
	public int maxWait;
	public int minWait;
	int location;

	void Awake()
	{
		wait = 20;
	}

	// Update is called once per frame
	void Update () 
	{
		if ((this.CompareTag ("top") && powerupManager.instance.IsTopPowerup == false) ||
		   (this.CompareTag ("bottom") && powerupManager.instance.IsBottomPowerup == false)) {
			wait--;
			if (wait == 0) {
				wait = Random.Range (minWait, maxWait);
				if ((this.CompareTag ("top") && powerupManager.instance.IsTopPowerup == false) ||
				   (this.CompareTag ("bottom") && powerupManager.instance.IsBottomPowerup == false)) {
					GameObject j = Instantiate (powerup, transform.position, transform.rotation) as GameObject;
					j.tag = this.tag;
					if (this.CompareTag ("top"))
						powerupManager.instance.topHealth = 3;
					else if (this.CompareTag ("bottom"))
						powerupManager.instance.bottomHealth = 3;
				}
			}
		}
	}
}

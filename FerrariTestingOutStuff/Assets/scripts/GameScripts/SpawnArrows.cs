using UnityEngine;
using System.Collections;

public class SpawnArrows : MonoBehaviour {

	int wait = 60;
	public int maxWait;
	public int minWait;

	public int lane;

	public GameObject enemy;
	public GameObject otherEnemy;
	public GameObject otherOtherEnemy;
	public GameObject otherOtherOtherEnemy;
	public GameObject thatOtherEnemy;

	// Update is called once per frame
	void Update()
	{
		lane = masterplan.instance.laneNum (this.gameObject);
		wait--;
		if (wait == 0) {
			int rand = Random.Range (0, 37);
			if (rand <= 4 && GM.instance.score >= 180) {
				if ((lane == 1 && masterplan.instance.airsinlane1 == false) ||
				    (lane == 2 && masterplan.instance.airsinlane2 == false) ||
				    (lane == 3 && masterplan.instance.airsinlane3 == false) ||
				    (lane == 4 && masterplan.instance.airsinlane4 == false) ||
				    lane == 0) {
					GameObject q = Instantiate (otherOtherEnemy, transform.position, transform.rotation) as GameObject;
					q.tag = this.tag;
				}			
			} else if (rand <= 14 && GM.instance.score >= 120) {
				Instantiate (otherOtherOtherEnemy, transform.position, transform.rotation);
			} else if (rand <= 24 && GM.instance.score >= 80) {
				Instantiate (otherEnemy, transform.position, transform.rotation);
			} else if (rand <= 30 && GM.instance.score >= 150) {
				Instantiate (thatOtherEnemy, transform.position, transform.rotation);
			} else {
				Instantiate (enemy, transform.position, transform.rotation);
			}
			wait = Random.Range (minWait, maxWait);
		}
	}


}
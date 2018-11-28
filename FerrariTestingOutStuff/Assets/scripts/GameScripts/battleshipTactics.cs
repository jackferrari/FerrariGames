using UnityEngine;
using System.Collections;

public class battleshipTactics : MonoBehaviour {

	public Vector2 Velocity;
	public int health;

	int wait = 60;
	public int maxWait;
	public int minWait;
	public GameObject minion;

	void Update()
	{

		wait--;
		if (wait == 0)
		{
			Instantiate (minion, transform.position, transform.rotation);
			wait = Random.Range (minWait, maxWait);
		}
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		this.transform.Translate (Velocity * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag("edge")) 
		{
			Destroy (this.gameObject);
		}
		if (other.gameObject.CompareTag("no"))
		{
			Destroy (other.gameObject);
			health--;
			if (health == 0) {
				GM.instance.UpdateWallet (5);
				GM.instance.score+=3;
				if (GM.instance.score > 60 && GM.instance.EnemiesUntilBad >= 1)
					GM.instance.EnemiesUntilBad--;
				Destroy (this.gameObject);
			}
		}
	}
}

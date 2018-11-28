using UnityEngine;
using System.Collections;

public class moneyEnemy : MonoBehaviour {

	Vector2 Velocity;
	public float speed;
	public int health;

	// Update is called once per frame
	void FixedUpdate () 
	{
		speed = speed * GM.instance.testTime;
		Velocity = new Vector2 (speed, 0);
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
				GM.instance.UpdateWallet (3);
				GM.instance.score+=2;
				if (GM.instance.score > 60 && GM.instance.EnemiesUntilBad >= 1)
					GM.instance.EnemiesUntilBad--;
				Destroy (this.gameObject);
			}
		}
	}
}

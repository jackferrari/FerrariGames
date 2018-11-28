using UnityEngine;
using System.Collections;

public class speedup : MonoBehaviour 
{
	Vector2 Velocity;
	public float ICheated;
	public int health;
	public float speed;

	void Awake()
	{
		health = Random.Range (3, 7);
	}
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
		if (other.gameObject.CompareTag ("no")) 
		{
			health--;
			Destroy (other.gameObject);
			GM.instance.score += 2;
			speed = ICheated * speed;
			if (health == 0) 
			{
				GM.instance.score += 6;
				GM.instance.UpdateWallet (2);
				Destroy (this.gameObject);
			}
		}
	}
}

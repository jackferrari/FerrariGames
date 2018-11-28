using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour 
{
	Vector2 Velocity;
	float actualSpeed;
	public float ICheated;

	// Update is called once per frame
	void FixedUpdate () 
	{
		actualSpeed = GM.instance.speed * GM.instance.testTime;
		Velocity = new Vector2 (actualSpeed, 0);
		this.transform.Translate (Velocity * Time.deltaTime);
		if (GM.instance.EnemiesUntilBad == 0) 
		{
			GM.instance.speed = GM.instance.speed * ICheated;
			GM.instance.EnemiesUntilBad = GM.instance.EnemiesUntilBad + 20;
		}
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag("edge")) 
		{
			Destroy (this.gameObject);
		}
	}
}

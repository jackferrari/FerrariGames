using UnityEngine;
using System.Collections;

public class swarm : MonoBehaviour {

	public float xChange;

	// Update is called once per frame
	void FixedUpdate ()
	{
		xChange = xChange * GM.instance.testTime;
		Vector2 Velocity = new Vector2 (xChange, 0);
		this.transform.Translate (Velocity * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag("edge")) 
		{
			Destroy (this.gameObject);
		}
		if (other.CompareTag ("no")) 
		{
			Destroy (other.gameObject);
			Destroy (this.gameObject);

		}
	}
}

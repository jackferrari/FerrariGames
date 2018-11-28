using UnityEngine;
using System.Collections;

public class tutorialShoot : MonoBehaviour {

	public Vector2 Velocity;
	// Update is called once per frame
	void FixedUpdate () 
	{
		this.transform.Translate (Velocity * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("edge")) 
		{
			Destroy (this.gameObject);
		}
		if (other.CompareTag ("pointee")) 
		{
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
	}
}

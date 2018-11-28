using UnityEngine;
using System.Collections;

public class TutorialEnemy : MonoBehaviour 
{

	public Vector2 Velocity;

	// Update is called once per frame
	void FixedUpdate () 
	{
		if (TutorialManager.instance.stage >= 3) 
		{
			this.transform.Translate (Velocity * Time.deltaTime);
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

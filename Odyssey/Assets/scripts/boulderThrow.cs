using UnityEngine;
using System.Collections;

public class boulderThrow : MonoBehaviour {

	public Vector2 boulderSpeed;

	// Update is called once per frame
	void FixedUpdate () {
		this.transform.Translate (boulderSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag ("catcher")) {
			Destroy (this.gameObject);
		}
	}
}

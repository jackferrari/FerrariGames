using UnityEngine;
using System.Collections;

public class shipScript : MonoBehaviour {

	Vector2 boatspeed;
	public float speed;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		boatspeed = new Vector2 (speed, 0);
		this.transform.Translate (boatspeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag ("edge")) {
			thunderer.instance.reset ();
			//Application.LoadLevel (1);
		}
		if (other.gameObject.CompareTag ("rock")) {
			Destroy (this.gameObject);
		}
		if (other.gameObject.CompareTag ("Island")) {
			thunderer.instance.loadRightLevel ();
		}
	}
}

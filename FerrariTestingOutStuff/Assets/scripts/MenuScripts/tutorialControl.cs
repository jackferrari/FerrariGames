using UnityEngine;
using System.Collections;

public class tutorialControl : MonoBehaviour {

	public GameObject projectile;
	public float spin;
	public float fasterSpin;

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.A) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))) {
			transform.Rotate (new Vector3 (0, 0, fasterSpin) * Time.deltaTime);	
		}
		else if (Input.GetKey(KeyCode.A))
			transform.Rotate (new Vector3 (0, 0, spin) * Time.deltaTime);

		if (Input.GetKey (KeyCode.D) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))) {
			transform.Rotate (new Vector3 (0, 0, -fasterSpin) * Time.deltaTime);	
		}
		else if (Input.GetKey(KeyCode.D))
			transform.Rotate (new Vector3 (0, 0, -spin) * Time.deltaTime);
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (projectile, transform.position, transform.rotation);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("pointee") || other.CompareTag("otherPoint") || other.CompareTag("moneyman")) {
			Destroy (other.gameObject);

		}
	}
}

using UnityEngine;
using System.Collections;

public class masterMariner : MonoBehaviour {

	public float speed;
	public int health;
	Vector2 boatspeed;
	public int numOfSi;

	// Update is called once per frame
	void Update () {
		boatspeed = new Vector2 (speed, 0);

		GameObject[] j = GameObject.FindGameObjectsWithTag("siern");
		numOfSi = j.Length;

		if (GameObject.FindGameObjectsWithTag ("siern").Length < 1) {
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
				this.transform.Translate (boatspeed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
				this.transform.Translate (-boatspeed * Time.deltaTime);
			}
		} else {
			if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
				this.transform.Translate (boatspeed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
				this.transform.Translate (-boatspeed * Time.deltaTime);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag ("rock")) {
			Destroy (other.gameObject);
			health--;
			if (health <= 0) {
				PlayerPrefs.SetInt ("adventure", 4);
				Application.LoadLevel (0);
			}
		}
		if (other.gameObject.CompareTag ("ending")) {
			earthshaker.instance.resetScene();
		}
	}
}

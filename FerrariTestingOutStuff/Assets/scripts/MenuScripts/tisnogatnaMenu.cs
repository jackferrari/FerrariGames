using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tisnogatnaMenu : MonoBehaviour 
{
	public int level;
	Vector2 Velocity;
	public float speed;
	public GameObject loading;

	// Update is called once per frame
	void FixedUpdate () 
	{
		Velocity = new Vector2 (speed, 0);
		this.transform.Translate (Velocity * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("edge")) {
			loading.SetActive (true);
			Application.LoadLevel (level);
		}
		if (other.gameObject.CompareTag("player")){
			Destroy (other.gameObject);
		}
	}
}

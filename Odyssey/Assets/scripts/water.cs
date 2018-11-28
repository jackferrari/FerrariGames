using UnityEngine;
using System.Collections;

public class water : MonoBehaviour {

	public Vector2 waterFlow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (waterFlow * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if(other.gameObject.CompareTag("catcher")) {
			Destroy (this.gameObject);
		}
	}
}

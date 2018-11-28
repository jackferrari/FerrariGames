using UnityEngine;
using System.Collections;

public class odysseus : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (GreyEyed.instance.odSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag ("penelope")) {
			GreyEyed.instance.Loving ();
		}
	}
}

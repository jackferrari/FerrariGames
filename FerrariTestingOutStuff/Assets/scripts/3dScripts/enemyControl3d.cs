using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class enemyControl3d : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		this.transform.Translate (new Vector3(3, 0, 0) * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("wall")) 
		{
			Destroy (this.gameObject);
		}
		if (other.CompareTag("no"))
		{
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
		if (other.CompareTag ("player")) 
		{
			loadMenue.instance.Loading ();
			Application.LoadLevel (0);
		}
	}
}

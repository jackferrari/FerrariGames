using UnityEngine;
using System.Collections;

public class projectile3d : MonoBehaviour 
{

	void FixedUpdate () 
	{
		this.transform.Translate (new Vector3(30, 0, 0) * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("wall")) 
		{
			Destroy (this.gameObject);
		}
	}
}

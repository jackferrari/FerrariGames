using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roof : MonoBehaviour {

	public int lose;

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag("person")) 
		{
			Application.LoadLevel (lose);
		}
	}
}

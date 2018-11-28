using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Infrustructure : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag("pointee") || other.gameObject.CompareTag("otherPoint")) 
		{
			Destroy (other.gameObject);
			wallBuilder.instance.wallDamage (this.gameObject, 1);
		}
		if (other.gameObject.CompareTag ("moneyman")) 
		{
			Destroy (other.gameObject);
			wallBuilder.instance.wallDamage (this.gameObject, 3);
		}
	}
}

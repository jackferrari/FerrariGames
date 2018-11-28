using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Controller3d : MonoBehaviour {

	public GameObject projectile;
	public float turn;
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.D)) 
		{
			transform.Rotate (new Vector3 (0, 90, 0) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) 
		{
			transform.Rotate (new Vector3 (0, -90, 0) * Time.deltaTime);
		}
//		if (Input.GetKey (KeyCode.W)) 
//		{
//			transform.Rotate (new Vector3 (0, 0, turn) * Time.deltaTime);
//		}
//		if (Input.GetKey (KeyCode.S)) 
//		{
//			transform.Rotate (new Vector3 (0, 0, -turn) * Time.deltaTime);
//		}

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Instantiate (projectile, transform.position, transform.rotation);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

	public static GM instance = null;
	public GameObject[] blockers;


	// Use this for initialization
	void Start () 
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		if (this.CompareTag("level1"))
			PlayerPrefs.SetString("level1", "Foobar");
		if (this.CompareTag("level2"))
			PlayerPrefs.SetString("level2", "Foobar");
		if (this.CompareTag("level3"))
			PlayerPrefs.SetString("level3", "Foobar");
		if (this.CompareTag("level4"))
			PlayerPrefs.SetString("level4", "Foobar");
		if (this.CompareTag("level5"))
			PlayerPrefs.SetString("level5", "Foobar");
		if (this.CompareTag("level6"))
			PlayerPrefs.SetString("level6", "Foobar");
	}
}

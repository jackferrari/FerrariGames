using UnityEngine;
using System.Collections;

public class advenKeep : MonoBehaviour {

	public int adven;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey ("adventure")) 
		{
			adven = PlayerPrefs.GetInt ("adventure");
		}
	}
}

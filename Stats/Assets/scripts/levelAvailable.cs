using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelAvailable : MonoBehaviour {

	public GameObject level1Button;
	public GameObject level2Button;
	public GameObject level3Button;
	public GameObject level4Button;
	public GameObject level5Button;
	public GameObject level6Button;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey ("level1"))
			level1Button.SetActive (true);
		if (PlayerPrefs.HasKey ("level2"))
			level2Button.SetActive (true);
		if (PlayerPrefs.HasKey ("level3"))
			level3Button.SetActive (true);
		if (PlayerPrefs.HasKey ("level4"))
			level4Button.SetActive (true);
		if (PlayerPrefs.HasKey ("level5"))
			level5Button.SetActive (true);
		if (PlayerPrefs.HasKey ("level6"))
			level6Button.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

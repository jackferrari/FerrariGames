using UnityEngine;
using System.Collections;

public class P_don : MonoBehaviour {

	public static P_don instance = null;
	public GameObject spawn1;
	public GameObject spawn2;
	public GameObject spawn3;
	public GameObject spawn4;
	public GameObject spawn5;
	public GameObject spawn6;
	public GameObject spawn7;

	public int countDown;

	// Use this for initialization
	void Start () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}

	// Update is called once per frame
	void Update () {
		countDown--;
		if (countDown <= 0) {
			PlayerPrefs.SetInt ("adventure", 5);
			Application.LoadLevel (2);
		}
		GameObject[] j = GameObject.FindGameObjectsWithTag("rock");
		if (j.Length >= 3){
			spawn1.SetActive (false);
			spawn2.SetActive (false);
			spawn3.SetActive (false);
			spawn4.SetActive (false);
			spawn5.SetActive (false);
			spawn6.SetActive (false);
			spawn7.SetActive (false);
		} else {
			spawn1.SetActive (true);
			spawn2.SetActive (true);
			spawn3.SetActive (true);
			spawn4.SetActive (true);
			spawn5.SetActive (true);
			spawn6.SetActive (true);
			spawn7.SetActive (true);
		}
	}
}

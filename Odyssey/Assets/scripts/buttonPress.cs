using UnityEngine;
using System.Collections;

public class buttonPress : MonoBehaviour {

	public GameObject loading;
	advenKeep ak;

	public void LoadScene(int loaderlevel)
	{
		GameObject j = GameObject.FindGameObjectWithTag ("hey");
		ak = j.GetComponent<advenKeep>();
		ak.adven = 3;
		PlayerPrefs.SetInt ("adventure", ak.adven);
		loading.SetActive (true);
		Application.LoadLevel (loaderlevel);
	}

	public void quit ()
	{
		loading.SetActive (true);
		Application.Quit ();
	}
}
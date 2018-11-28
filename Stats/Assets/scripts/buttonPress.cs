using UnityEngine;
using System.Collections;

public class buttonPress : MonoBehaviour {

	public GameObject loading;

	public void LoadScene(int loaderlevel)
	{
		loading.SetActive (true);
		Application.LoadLevel (loaderlevel);
	}

	public void quit ()
	{
		loading.SetActive (true);
		Application.Quit ();
	}
	public void NewHighScore()
	{
		if (PlayerPrefs.HasKey ("level1"))
			PlayerPrefs.DeleteKey ("level1");
		if (PlayerPrefs.HasKey ("level2"))
			PlayerPrefs.DeleteKey ("level2");
		if (PlayerPrefs.HasKey ("level3"))
			PlayerPrefs.DeleteKey ("level3");
		if (PlayerPrefs.HasKey ("level4"))
			PlayerPrefs.DeleteKey ("level4");
		if (PlayerPrefs.HasKey ("level5"))
			PlayerPrefs.DeleteKey ("level5");
		if (PlayerPrefs.HasKey ("level6"))
			PlayerPrefs.DeleteKey ("level6");
	}
}
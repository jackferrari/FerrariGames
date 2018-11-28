using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class loadOnClick : MonoBehaviour 
{
	public GameObject loading;
	tisnogatnaMenu tisnogatna;

	public void LoadScene(int loaderlevel)
	{
		GameObject j = GameObject.FindGameObjectWithTag ("tis");
		tisnogatna = j.GetComponent<tisnogatnaMenu>();

		tisnogatna.level = loaderlevel;
		tisnogatna.speed = 15;


//		loading.SetActive (true);
//		Application.LoadLevel (loaderlevel);
	}

	public void quit()
	{
		loading.SetActive (true);
		Application.Quit ();
	}
}

using UnityEngine;
using System.Collections;

public class loadMenue : MonoBehaviour {

	public GameObject loading;

	public static loadMenue instance = null;

	void Start()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}

	public void Loading()
	{
		loading.SetActive (true);
	}
}

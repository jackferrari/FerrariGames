using UnityEngine;
using System.Collections;

public class earthshaker : MonoBehaviour {
	int scenes;

	public GameObject cliff1;
	public GameObject cliff2;
	GameObject lastr;

	public GameObject Odysseus;
	GameObject Ody;
	public Vector2 odpos;

	public GameObject las2;

	public GameObject las3;
	public GameObject las4;

	public GameObject las5;
	public GameObject las6;

	public static earthshaker instance = null;

	// Use this for initialization
	void Start () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		scenes = 0;

		lastr = Instantiate (cliff1, this.transform.position, Quaternion.identity) as GameObject;

		Ody = Instantiate (Odysseus, odpos, Quaternion.identity) as GameObject;
		Ody.transform.Rotate (new Vector2 (0, 180));

		choosePos (las3, las4);
		choosePos (las5, las6);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void choosePos(GameObject obj1, GameObject obj2) {
		int choice = Random.Range(0, 2);
		if (choice == 0) {
			obj1.SetActive (true);
			obj2.SetActive (false);
		} else {
			obj1.SetActive (false);
			obj2.SetActive (true);
		}
	}

	public void resetScene () {
		scenes++;
		print ("scene" + scenes);
		Ody.transform.position = odpos;

		if (scenes == 5) {
			PlayerPrefs.SetInt ("adventure", 4);
			Application.LoadLevel (2);
		}

		Destroy (lastr.gameObject);
		if (scenes % 2 == 0) 
			lastr = Instantiate (cliff1, this.transform.position, Quaternion.identity) as GameObject;
		else
			lastr = Instantiate (cliff2, this.transform.position, Quaternion.identity) as GameObject;

		choosePos (las3, las4);
		choosePos (las5, las6);

	}
}

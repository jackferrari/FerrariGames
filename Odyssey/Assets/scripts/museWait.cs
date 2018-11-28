using UnityEngine;
using System.Collections;

public class museWait : MonoBehaviour {

	public int countdown;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		countdown--;
		if (countdown == 0)
			Application.LoadLevel (2);
	}
}

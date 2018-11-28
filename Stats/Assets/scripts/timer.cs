using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {

	public int countdown;

	void Start() {
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
	
	// Update is called once per frame
	void Update () {
		countdown--;
		if (countdown <= 0) {
			Application.LoadLevel (0);
		}
		Cursor.visible = true;
	}
}

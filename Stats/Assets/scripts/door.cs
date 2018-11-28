using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {

	bool hover = false;

	public Renderer rend;
	void Start() {
		rend = GetComponent<Renderer>();
	}
	void OnMouseEnter() {
		rend.material.color = Color.red;
		hover = true;
	}
	void OnMouseOver() {
		//rend.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
	}
	void OnMouseExit() {
		rend.material.color = Color.white;
		hover = false;
	}
	void OnMouseDown()
	{
		if (hover)
			Application.LoadLevel (Application.loadedLevel + 1);
	}
}

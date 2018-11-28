using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door1 : MonoBehaviour {

	bool hover = false;
	bool roofFall = false;
	public Vector3 Velocity;
	public Vector3 Velocity2;
	public Vector3 Velocity3;
	public Vector3 Velocity4;
	public Vector3 Velocity5;
	public GameObject roof;
	public GameObject wall1;
	public GameObject wall2;
	public GameObject wall3;
	public GameObject wall4;

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
			roofFall = true;
		for (int i = 0; i < GM.instance.blockers.Length; i++) {
			GM.instance.blockers [i].SetActive (true);
		}
	}

	void Update(){
		if (roofFall) {
			roof.transform.Translate (Velocity * Time.deltaTime);
			wall1.transform.Translate (Velocity2 * Time.deltaTime);
			wall2.transform.Translate (Velocity3 * Time.deltaTime);
			wall3.transform.Translate (Velocity4 * Time.deltaTime);
			wall4.transform.Translate (Velocity5 * Time.deltaTime);
		}
	}
}

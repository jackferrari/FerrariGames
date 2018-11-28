using UnityEngine;
using System.Collections;

public class GreyEyed : MonoBehaviour {

	public GameObject od;
	public GameObject pen;
	public GameObject love;

	public Vector2 odSpeed;
	public Vector2 penSpeed;

	bool countDownStart;
	public int countdown;

	public static GreyEyed instance = null;

	// Use this for initialization
	void Start () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		
		love.SetActive (false);
		countDownStart = false;
	}
	
	public void Loving () {
		odSpeed = new Vector2 (0, 0);
		penSpeed = new Vector2 (0, 0);
		love.SetActive (true);
		countDownStart = true;
	}

	void Update() {
		if (countDownStart) {
			countdown--;
		}
		if (countdown <= 0) {
			Application.LoadLevel (0);
		}
	}
}

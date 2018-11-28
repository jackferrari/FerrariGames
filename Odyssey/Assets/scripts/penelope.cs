using UnityEngine;
using System.Collections;

public class penelope : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		this.transform.Translate (GreyEyed.instance.penSpeed * Time.deltaTime);
	}
}

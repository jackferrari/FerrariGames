using UnityEngine;
using System.Collections;

public class thunderer : MonoBehaviour {

	public GameObject water;
	public GameObject boat;
	public GameObject island;
	public GameObject initIsland;
	public GameObject faceWater;

	GameObject odShip;
	GameObject adventIsland;
	GameObject apearedWater;

	public int boatSpeed;
	public int normalSpeed;
	public int slowSpeed;

	public Vector2 startPosB;
	public Vector2 startstartPosB;
	public Vector2 startPosW;
	public Vector2 startPosFW;
	public Vector2 startPosI;

	int countdown;

	advenKeep ak;

	public static thunderer instance = null;

	// Use this for initialization
	void Start () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		odShip = Instantiate (boat, startstartPosB, Quaternion.identity) as GameObject;
		apearedWater = Instantiate (water, startPosW, Quaternion.identity) as GameObject;
		countdown = 3;
		boatSpeed = normalSpeed;
	}

	public void reset()
	{
		countdown--;
		Destroy (odShip.gameObject);
		Destroy (apearedWater.gameObject);
		if (adventIsland) {
			Destroy (adventIsland.gameObject);
		}
		if (initIsland) {
			Destroy (initIsland.gameObject);
		}
		odShip = Instantiate (boat, startPosB, Quaternion.identity) as GameObject;
		int waterCheck = Random.Range (0, 2);
		print ("water " + waterCheck);
		if (waterCheck == 0)
			apearedWater = Instantiate (faceWater, startPosFW, Quaternion.identity) as GameObject;
		else
			apearedWater = Instantiate(water, startPosW, Quaternion.identity) as GameObject;
		int islandCheck = Random.Range (0, 1);
		print ("island " + islandCheck);
		if (islandCheck == 0 && countdown <= 0) {
			adventIsland = Instantiate (island, startPosI, Quaternion.identity) as GameObject;
			countdown = 2;
			boatSpeed = slowSpeed;
		} else {
			boatSpeed = normalSpeed;
		}
	}
	
	public void loadRightLevel () {
		GameObject j = GameObject.FindGameObjectWithTag ("hey");
		ak = j.GetComponent<advenKeep>();
		Application.LoadLevel (ak.adven);
	}
}

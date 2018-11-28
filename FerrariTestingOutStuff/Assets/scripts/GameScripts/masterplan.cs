using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class masterplan : MonoBehaviour 
{
	public GameObject Arrow;

	public bool airsinlane1;
	public bool airsinlane2;
	public bool airsinlane3;
	public bool airsinlane4;

	GameObject ArrowSpawner;
	GameObject ArrowSpawner2;
	GameObject ArrowSpawner3;
	GameObject ArrowSpawner4;

	public Vector3 spawnposition1;
	public Vector3 spawnposition2;
	public Vector3 spawnposition3;
	public Vector3 spawnposition4;

	public float rot1;
	public float rot2;
	public float rot3;

	public static masterplan instance = null;


	// Use this for initialization
	void Start () 
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		ArrowSpawner = Instantiate (Arrow, spawnposition1, Quaternion.identity) as GameObject;
		ArrowSpawner.tag = "Lane 1";
		ArrowSpawner.transform.Rotate (new Vector3 (0, 0, rot2));

		ArrowSpawner2 = Instantiate (Arrow, spawnposition2, Quaternion.identity) as GameObject;
		ArrowSpawner2.tag = "lane 2";
		ArrowSpawner2.transform.Rotate (new Vector3 (0, 0, rot3));

		ArrowSpawner3 = Instantiate (Arrow, spawnposition3, Quaternion.identity) as GameObject;
		ArrowSpawner3.tag = "lane 3";
		ArrowSpawner3.transform.Rotate (new Vector3 (0, 0, rot1));

		ArrowSpawner4 = Instantiate (Arrow, spawnposition4, Quaternion.identity) as GameObject;
		ArrowSpawner4.tag = "lane 4";
		ArrowSpawner4.transform.Rotate (new Vector3 (0, 0, -200));
	}

	public int laneNum(GameObject self)
	{
		if (self.CompareTag("Lane 1"))
			return 1;
		if (self.CompareTag("lane 2"))
			return 2;
		if (self.CompareTag("lane 3"))
			return 3;
		if (self.CompareTag("lane 4"))
			return 4;
		else
			return 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject[] j = GameObject.FindGameObjectsWithTag ("Lane 1");
		if (j.Length - 1 >= 1) {
			airsinlane1 = true;
		} else 
		{
			airsinlane1 = false;
		}
		GameObject[] a = GameObject.FindGameObjectsWithTag ("lane 2");
		if (a.Length - 1 >= 1) 
		{
			airsinlane2 = true;
		} else 
		{
			airsinlane2 = false;
		}
		GameObject[] c = GameObject.FindGameObjectsWithTag ("lane 3");
		if (c.Length - 1 >= 1) 
		{
			airsinlane3 = true;
		} else 
		{
			airsinlane3 = false;
		}
		GameObject[] k = GameObject.FindGameObjectsWithTag ("lane 4");
		if (k.Length - 1 >= 1) 
		{
			airsinlane4 = true;
		} else 
		{ 
			airsinlane4 = false;
		}
	}
}

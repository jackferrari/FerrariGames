//using UnityEngine;
//using System.Collections;
//
//public class manageWalls : MonoBehaviour {
//
//	public GameObject WallPrime;
//	public GameObject PrimeWall;
//
//	public Vector3 wallposition1;
//	public Vector3 wallposition2;
//	public Vector3 wallposition3;
//	public Vector3 wallposition4;
//
//	bool isWall1There;
//	bool isWall2There;
//	bool isWall3There;
//	bool isWall4There;
//
//	public int wall1Health;
//	public int wall2Health;
//	public int wall3Health;
//	public int wall4Health;
//
//	public static manageWalls instance = null;
//
//	// Use this for initialization
//	void Start () 
//	{
//		if (instance == null)
//			instance = this;
//		else if (instance != this)
//			Destroy (gameObject);
//
//		isWall1There = false;
//		isWall2There = false;
//		isWall3There = false;
//		isWall4There = false;
//	}
//	
//	// Update is called once per frame
//	void Update()
//	{
//		if (Input.GetKey (KeyCode.H) && GM.instance.ActualMoney >= 15) {
//			makeWall1 (WallPrime, -15);
//		}
//		if (Input.GetKey (KeyCode.J) && GM.instance.ActualMoney >= 15) {
//			makeWall2 (WallPrime, -15);
//		}
//		if (Input.GetKey (KeyCode.K) && GM.instance.ActualMoney >= 15) {
//			makeWall3 (WallPrime, -15);
//		}
//		if (Input.GetKey (KeyCode.L) && GM.instance.ActualMoney >= 15) {
//			makeWall4 (WallPrime, -15);
//		}
//	}
//}

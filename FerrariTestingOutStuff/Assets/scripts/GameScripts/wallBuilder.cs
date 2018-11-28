using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wallBuilder : MonoBehaviour 
{
	public GameObject WallPrime;
	public GameObject PrimeWall;

	public Vector2 wallposition1;
	public Vector2 wallposition2;
	public Vector2 wallposition3;
	public Vector2 wallposition4;

	bool isWall1There;
	bool isWall2There;
	bool isWall3There;
	bool isWall4There;

	public int wall1Health;
	public int wall2Health;
	public int wall3Health;
	public int wall4Health;

	public GameObject button1;
	public GameObject button2;
	public GameObject button3;
	public GameObject button4;

	public static wallBuilder instance = null;

	void Start()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		isWall1There = false;
		isWall2There = false;
		isWall3There = false;
		isWall4There = false;
	}

	void Update()
	{
		if (Input.GetKey (KeyCode.H) && GM.instance.ActualMoney >= 15) {
			makeWall1 (WallPrime, -15);
		}
		if (Input.GetKey (KeyCode.J) && GM.instance.ActualMoney >= 15) {
			makeWall2 (WallPrime, -15);
		}
		if (Input.GetKey (KeyCode.K) && GM.instance.ActualMoney >= 15) {
			makeWall3 (WallPrime, -15);
		}
		if (Input.GetKey (KeyCode.L) && GM.instance.ActualMoney >= 15) {
			makeWall4 (WallPrime, -15);
		}
	}



	public void MakeAllWalls()
	{
		makeWall1 (PrimeWall, 0);
		makeWall2 (PrimeWall, 0);
		makeWall3 (PrimeWall, 0);
		makeWall4 (PrimeWall, 0);

	}

	private void makeWall1(GameObject wall, int cost)
	{
		if (isWall1There == false) {
			GameObject newWall = Instantiate (wall, wallposition1, Quaternion.identity) as GameObject;
			newWall.transform.Rotate (new Vector3 (0, 0, -26));
			isWall1There = true;
			GM.instance.UpdateWallet (cost);
			if(newWall.CompareTag("weak"))
				wall1Health = 1;
			else
				wall1Health = 3;
			newWall.tag = "wall1";
			button1.SetActive (false);
		}
	}

	private void makeWall2(GameObject wall, int cost)
	{
		if (isWall2There == false) {
			GameObject newWall = Instantiate (wall, wallposition2, Quaternion.identity) as GameObject;
			newWall.transform.Rotate (new Vector3 (0, 0, 26));
			isWall2There = true;
			GM.instance.UpdateWallet (cost);
			if(newWall.CompareTag("weak"))
				wall2Health = 1;
			else
				wall2Health = 3;
			newWall.tag = "wall2";
			button2.SetActive (false);
		}
	}

	private void makeWall3(GameObject wall, int cost)
	{
		if (isWall3There == false) {
			GameObject newWall = Instantiate (wall, wallposition3, Quaternion.identity) as GameObject;
			newWall.transform.Rotate (new Vector3 (0, 0, 26));
			isWall3There = true;
			GM.instance.UpdateWallet (cost);
			if(newWall.CompareTag("weak"))
				wall3Health = 1;
			else
				wall3Health = 3;
			newWall.tag = "wall3";
			button3.SetActive (false);
		}
	}

	private void makeWall4(GameObject wall, int cost)
	{
		if (isWall4There == false) {
			GameObject newWall = Instantiate (wall, wallposition4, Quaternion.identity) as GameObject;
			newWall.transform.Rotate (new Vector3 (0, 0, -26));
			isWall4There = true;
			GM.instance.UpdateWallet (cost);
			if(newWall.CompareTag("weak"))
				wall4Health = 1;
			else
				wall4Health = 3;
			newWall.tag = "wall4";
			button4.SetActive (false);
		}
	}
		
	public void wallDamage(GameObject block, int damage)
	{
		if(block.CompareTag("wall1"))
		{
			wall1Health-=damage;
			if (wall1Health <= 0) 
			{
				Destroy (block.gameObject);
				isWall1There = false;
				button1.SetActive (true);
			}
		}

		if(block.CompareTag("wall2"))
		{
			wall2Health-=damage;
			if (wall2Health <= 0) 
			{
				Destroy (block.gameObject);
				isWall2There = false;
				button2.SetActive (true);
			}
		}

		if(block.CompareTag("wall3"))
		{
			wall3Health-=damage;
			if (wall3Health <= 0) 
			{
				Destroy (block.gameObject);
				isWall3There = false;
				button3.SetActive (true);
			}
		}

		if(block.CompareTag("wall4"))
		{
			wall4Health-=damage;
			if (wall4Health <= 0) 
			{
				Destroy (block.gameObject);
				isWall4There = false;
				button4.SetActive (true);
			}
		}
	}

}

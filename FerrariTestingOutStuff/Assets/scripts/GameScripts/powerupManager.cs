using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class powerupManager : MonoBehaviour 
{
	public GameObject spawner;
	public bool IsTopPowerup;
	public bool IsBottomPowerup;
	public bool powerUpActive;
	public bool powerUpActivate;
	public Text powerupText;
	public int[] effects;
	public int timeUntilRemove;
	public int countDown;
	public int power;
	private PlayerControl pc;

	public Vector2 top;
	public Vector2 bottom;

	public int topHealth;
	public int bottomHealth;

	public static powerupManager instance = null;

	// Use this for initialization
	void Start () 
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		timeUntilRemove = countDown;

		GameObject ja = Instantiate(spawner, top, Quaternion.identity) as GameObject;
		ja.tag = "top";
		GameObject ck = Instantiate (spawner, bottom, Quaternion.identity) as GameObject;
		ck.tag = "bottom";
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject j = GameObject.FindGameObjectWithTag ("pointed");
		pc = j.GetComponent<PlayerControl>();

		GameObject[] t = GameObject.FindGameObjectsWithTag ("top");
		if (t.Length - 1 == 1)
			IsTopPowerup = true;
		else
			IsTopPowerup = false;
		GameObject[] b = GameObject.FindGameObjectsWithTag ("bottom");
		if (b.Length - 1 == 1)
			IsBottomPowerup = true;
		else
			IsBottomPowerup = false;
		if (powerUpActivate) {
			addPowerup ();
		}

		if (effects.Length > 0) 
		{
			timeUntilRemove--;
			if (timeUntilRemove == 0) {
				UndoEffect ();
				shortenArray ();
				timeUntilRemove = countDown;
			}
		}

		if (effects.Length > 0)
			printEffects ();
		else
			powerupText.text = "Powerup: ";
	}
		
	void UndoEffect()
	{
		int p = effects [0];
		if (p == 1 || p == 3)
			pc.initialSpeed = 0;
		if (p == 4)
			power = 1;
	}

	void shortenArray()
	{
		int[] temp = new int[effects.Length - 1];
		for (int i = 1; i <= temp.Length; i++) 
		{
			temp [i - 1] = effects [i];
		}
		effects = temp;
	}

	void addPowerup()
	{
		int rand = Random.Range (0, 6);
		if (rand == 1) {
			pc.initialSpeed = 20;

			int[] temp = new int[effects.Length+1];
			effects.CopyTo(temp, 0);
			effects = temp;
			effects [effects.Length - 1] = 1;
		}
		if (rand == 0) {
			wallBuilder.instance.MakeAllWalls ();

			int[] temp = new int[effects.Length+1];
			effects.CopyTo(temp, 0);
			effects = temp;
			effects [effects.Length - 1] = 2;
		}
		if (rand == 2) {
			pc.initialSpeed = -20;

			int[] temp = new int[effects.Length+1];
			effects.CopyTo(temp, 0);
			effects = temp;
			effects [effects.Length - 1] = 3;
		}
		if (rand == 3) {
			power = 2;

			int[] temp = new int[effects.Length+1];
			effects.CopyTo(temp, 0);
			effects = temp;
			effects [effects.Length - 1] = 4;
		}
		if (rand == 4) {
			GM.instance.loseHealth (-1);

			int[] temp = new int[effects.Length+1];
			effects.CopyTo(temp, 0);
			effects = temp;
			effects [effects.Length - 1] = 5;
		}
		if (rand == 5) {
			GM.instance.UpdateWallet(-(GM.instance.ActualMoney - (GM.instance.ActualMoney / 2)));

			int[] temp = new int[effects.Length+1];
			effects.CopyTo(temp, 0);
			effects = temp;
			effects [effects.Length - 1] = 6;
		}
		powerUpActivate = false;
	}
		
	void printEffects()
	{
		powerupText.text = "Powerups: ";
		for (int i = 0; i < effects.Length; i++) 
		{
			powerupText.text = powerupText.text + effect (effects [i]);
		}
	}

	string effect(int i)
	{
		if (i == 1)
			return "speed increase, ";
		if (i == 2)
			return "walls, ";
		if (i == 3)
			return "speed decrease, ";
		if (i == 4)
			return "power increase, ";
		if (i == 5)
			return "health increase, ";
		if (i == 6)
			return "money decrease, ";
		return null;
	}
}

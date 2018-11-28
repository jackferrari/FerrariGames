using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour 
{
	public GameObject player;
	public GameObject background;

	public float testTime;

	public Text health;
	public Text money;
	public Text scoreDisplay;


	public int hits;
	public int ActualMoney;
	public int score;
	public int EnemiesUntilBad;
	public float speed;

	private scorekeeper sk;

	public static GM instance = null;


	// Use this for initialization
	void Start ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		ActualMoney = 0;

		GameObject j = GameObject.FindGameObjectWithTag ("hey");
		sk = j.GetComponent<scorekeeper>();

		Instantiate (player, new Vector2 (0, 0), Quaternion.identity);

	}

	void Update()
	{
		sk.setScore(score);
		scoreDisplay.text = "Score: " + score;
		if (score > sk.highscore) 
		{
			sk.highscore = score;
		}
	}
		
	public void loseHealth(int i)
	{
		hits -= i;
		health.text = "Health: " + hits;
		if (hits == 0) 
		{
			saveScore ();
			Application.LoadLevel (2);
		}
	}

	public void UpdateWallet(int change)
	{
		ActualMoney = ActualMoney + change;
		money.text = "Money: " + ActualMoney;
	}

	public void saveScore()
	{
		PlayerPrefs.SetInt ("score", sk.score);
		PlayerPrefs.SetInt ("highscore", sk.highscore);
	}

	public void reset()
	{
		Application.LoadLevel (Application.loadedLevel);
	}
}
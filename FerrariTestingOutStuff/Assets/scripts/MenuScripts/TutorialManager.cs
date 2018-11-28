 using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour 
{
	public Text tutorial;
	public Text prompt;
	public GameObject Arrow;
	public int stage;
	public static TutorialManager instance = null;
	public GameObject walls;
	public GameObject enemyGuide;
	public GameObject powerupprefab;

	void Start()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		
		tutorial.text = "Welcome to Arrow Dyfence!";
		stage = 0;
	}

	void Update()
	{
		if (Input.GetKeyUp (KeyCode.E)) 
		{
			stage++;
			if (stage == 1) 
			{
				tutorial.text = "Press the A and D keys to turn";
			}
			if (stage == 2) 
			{
				tutorial.text = "Press the space key shoot. Try to defeat these enemies.";
				Instantiate (Arrow, new Vector2 (-7, 0), Quaternion.identity);
				GameObject j = Instantiate(Arrow, new Vector2 (7, 0), Quaternion.identity) as GameObject;
				j.transform.Rotate(new Vector3(0, 0 , 180));
			}
			if (stage == 3) 
			{
				Instantiate(Arrow, new Vector2 (-7, 0), Quaternion.identity);
				GameObject a = Instantiate(Arrow, new Vector2 (7, 0), Quaternion.identity) as GameObject;
				a.transform.Rotate(new Vector3(0, 0 , 180));
				tutorial.text = "In Game they will move to defeat you";
			}
			if (stage == 4) 
			{
				tutorial.text = "These are walls. They usually take 3 hits before being destroyed and stop enemies. " +
					"They cost 15 money to build";
				walls.SetActive (true);
			}
			if (stage == 5) 
			{
				tutorial.text = "Press shift to sprint. While this will increase your speed, it will drain your money";
			}
			if (stage == 6) 
			{
				Instantiate(powerupprefab, new Vector2 (-7, 0), Quaternion.identity);
				Instantiate(powerupprefab, new Vector2 (7, 0), Quaternion.identity);
				tutorial.text = "These are powerups. They have random effects that will either help or hurt you";
			}
			if (stage == 7) {
				enemyGuide.SetActive (true);
				tutorial.text = "These are the enemies you will fight.";
				prompt.text = "Press E to return to main menu";
			}
			if(stage == 8)
				Application.LoadLevel (0);
		}
	}
}

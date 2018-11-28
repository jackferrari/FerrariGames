using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Defeat : MonoBehaviour 
{

	public GameObject loading;
	private scorekeeper sk;
	public Text scoretext;
	public Text highscoretext;

	void Start()
	{
		GameObject j = GameObject.FindGameObjectWithTag ("hey");
		sk = j.GetComponent<scorekeeper>();

	}

	void Update()
	{
		scoretext.text = "Your Score: " + sk.score;
		highscoretext.text = "Highscore: " + sk.highscore;
	}

	public void LoadScene(int level)
	{
		loading.SetActive (true);
		Application.LoadLevel (level);
	}

	public void quit()
	{
		loading.SetActive (true);
		Application.Quit ();
	}
}

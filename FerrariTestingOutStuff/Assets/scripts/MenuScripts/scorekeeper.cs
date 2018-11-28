using UnityEngine;
using System.Collections;

public class scorekeeper : MonoBehaviour 
{
	public int score;
	public int highscore;

	void Start()
	{
		if (PlayerPrefs.HasKey ("highscore")) 
		{
			highscore = PlayerPrefs.GetInt ("highscore");
		}
		if (PlayerPrefs.HasKey ("score")) 
		{
			if (Application.loadedLevel == 0) 
			{
				PlayerPrefs.DeleteKey ("score");
			} else 
			{
				score = PlayerPrefs.GetInt ("score");
			}
		}
	}

	public void setScore(int i)
	{
		score = i;
	}

	public void NewHighScore()
	{
		PlayerPrefs.DeleteKey ("highscore");
		highscore = 0;
	}

	public int getScore()
	{
		return score;
	}

	public void setHighScore (int i)
	{
		highscore = i;
	}
}

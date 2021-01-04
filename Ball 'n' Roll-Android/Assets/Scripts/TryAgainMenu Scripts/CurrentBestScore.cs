using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CurrentBestScore : MonoBehaviour
{
    public Text CurrentBestScore1;
    public static int bestScore = 0;

	public static void WriteScoreToFlash(int score)
	{
		PlayerPrefs.SetInt("Score", score);
	}	

	void Update()
    {
        if (ScoreText.score > bestScore)
        {
			
			bestScore = ScoreText.score;
			CurrentBestScore1.text = "High Score: " + bestScore.ToString("0");
			WriteScoreToFlash(bestScore);
        }
        else
        {
            CurrentBestScore1.text = "High Score: " + bestScore.ToString("0");
        }
    }
}

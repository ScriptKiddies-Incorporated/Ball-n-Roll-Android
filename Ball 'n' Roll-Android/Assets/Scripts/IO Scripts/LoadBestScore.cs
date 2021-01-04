using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadBestScore : MonoBehaviour
{
	
	public static int LoadBestScoreFromFlash()
	{
		int score;
		score = PlayerPrefs.GetInt("Score");

		return score;
	}
	void Start()
	{
		CurrentBestScore.bestScore = LoadBestScoreFromFlash();	  
	}
	
}



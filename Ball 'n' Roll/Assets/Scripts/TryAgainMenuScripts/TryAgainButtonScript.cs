﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainButtonScript : MonoBehaviour
{
    public void TryAgain()
    {
        ScoreText.objcount = 0;
        ScoreText.cordChacker = 0;
        ScoreText.timeController2 = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
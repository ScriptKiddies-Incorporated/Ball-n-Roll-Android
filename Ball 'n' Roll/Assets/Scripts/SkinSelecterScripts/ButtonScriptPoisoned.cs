﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptPoisoned : MonoBehaviour
{
    public void ButtonscriptPoisoned()
    {
        ScoreText.objCount = 0;
        ScoreText.cordChecker = 0;
        ScoreText.timeController2 = false;
        ButtonScriptHexagonCarbon.skinChoice = "Poisoned";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
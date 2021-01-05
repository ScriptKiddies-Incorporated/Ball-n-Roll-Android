using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;
using UnityEngine.Android;

public class LoadGameScene : MonoBehaviour
{
	public GameObject GameMusic;
	static public GameObject _GameMusic;
	public void ShowSkinScene()
	{
        PlayButtonScript.skinLoader.allowSceneActivation = true;
	}

	private void Awake()
	{
		
			Screen.SetResolution(1920, 1080, true, 60);
			Screen.fullScreen = true;
	}
	
	private void Start()
	{
	    _GameMusic = Instantiate(GameMusic);
		DontDestroyOnLoad(GameMusic);
		ShowSkinScene();
	}

	public static void StopGameMusic()
	{
		Destroy(_GameMusic);
	}
}



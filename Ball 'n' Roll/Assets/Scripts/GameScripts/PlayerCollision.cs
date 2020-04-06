﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public static bool cameraPos = true;
	public GameObject greenSound;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.collider.name == "Obstacle" || collisionInfo.collider.name == "Obstacle(Clone)")
        {
            ObstacleSpawnerScript.timeController = false;
            Destroy(gameObject);
             Thread.Sleep(350);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

		if (collisionInfo.collider.name == "GreenCheckpoint(Clone)")
		{
			Instantiate(greenSound);
		}
    }

}

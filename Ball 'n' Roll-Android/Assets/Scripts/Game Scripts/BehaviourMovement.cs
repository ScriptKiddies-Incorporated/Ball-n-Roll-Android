using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class BehaviourMovement : MonoBehaviour
{
    public GameObject ballPlayerNull;
    public Rigidbody Ball;
    public static bool pauseCondition = false;
    public int sidewaysForce;
    public static float forwardForce = 400f;
    public static bool planeCollisionChecker = true;

    void FixedUpdate()
    {
        if (ballPlayerNull != null)
        {
            Ball.AddForce(0, 0, -forwardForce * Time.deltaTime);

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.position.x < Screen.width / 2 && touch.phase != TouchPhase.Began)
                {
                    Ball.AddForce(1200 * Time.deltaTime, 0, 0);
                }
                else if (touch.position.x > Screen.width / 2 && touch.phase != TouchPhase.Began)
                {
                    Ball.AddForce(-1200 * Time.deltaTime, 0, 0);
                }
            }


            if (Ball.position.y < -50f)
            {
                print("GAME OVER!!!");
                ObstacleSpawnerScript.timeController = false;
                PlayerCollision.redSoundCondition = true;
                Destroy(gameObject);
                Thread.Sleep(500);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }


           // print(Ball.position.y);
            if (Ball.position.y <= 1.75f && Ball.position.y >= -1.43f)
            {
                planeCollisionChecker = true;
            }
            else
            {
                    planeCollisionChecker = false;
            }
           // print(planeCollisionChecker);
        }
    }
    

 }



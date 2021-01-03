using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollowBall : MonoBehaviour
{
    public Transform BallPlayerLight;
    public Vector3 offset;
    public GameObject ballPlayerNull1;

    void Update()
    {

        if (ballPlayerNull1 != null)
        {
            transform.position = BallPlayerLight.position + offset;
        }

    }
}

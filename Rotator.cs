using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float speed1 = 100f, speed2 = -160f;
    public float currentSpeed;

    public bool randomizeSpeed;

    // Use this for initialization
    void Start()
    {

        if (randomizeSpeed)
        {

            int rand = Random.Range(0, 2);

            if (rand == 0)
            {
                currentSpeed = speed1;
            }
            else
            {
                currentSpeed = speed2;
            }

        }


    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, currentSpeed * Time.deltaTime);
    }



} // class


































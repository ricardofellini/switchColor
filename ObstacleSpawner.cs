using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject smallCirclePrefab, largeCirclePrefab, colorSwitchPrefab;

    public float smallCircleDistance = 10f, largeCircleDistance = 11f;
    public float colorSwitcherDistance = 5f;

    public float obstacleSpawnerDistance = 40f;

    private float currentY = 2f;

    private bool spawnedLargeCircle;

    // Use this for initialization
    void Start()
    {
        SpawnNewCircles();
    }

    void SpawnNewCircles()
    {

        GameObject go = null;

        go = Instantiate(smallCirclePrefab);
        Vector2 temp1 = Vector2.zero;
        temp1.y = currentY;

        go.transform.position = temp1;

        temp1.y += colorSwitcherDistance;
        Instantiate(colorSwitchPrefab, temp1, Quaternion.identity);

        int rand = Random.Range(0, 2);

        for (int i = 0; i < 5; i++)
        {

            if (rand == 0)
            {

                go = Instantiate(smallCirclePrefab);
                currentY += smallCircleDistance;

                Vector2 temp = Vector2.zero;
                temp.y = currentY;

                go.transform.position = temp;

                temp.y += colorSwitcherDistance;
                Instantiate(colorSwitchPrefab, temp, Quaternion.identity);


            }
            else
            {

                if (!spawnedLargeCircle)
                {

                    go = Instantiate(largeCirclePrefab);
                    currentY += largeCircleDistance;

                    Vector2 temp = Vector2.zero;
                    temp.y = currentY;

                    go.transform.position = temp;

                    temp.y += colorSwitcherDistance;
                    Instantiate(colorSwitchPrefab, temp, Quaternion.identity);

                    spawnedLargeCircle = true;

                }
                else
                {

                    go = Instantiate(smallCirclePrefab);
                    currentY += smallCircleDistance;

                    Vector2 temp = Vector2.zero;
                    temp.y = currentY;

                    go.transform.position = temp;

                    temp.y += colorSwitcherDistance;
                    Instantiate(colorSwitchPrefab, temp, Quaternion.identity);

                }

            }

            rand = Random.Range(0, 2);

        } // for loop

        Vector2 spawnerTemp = transform.position;
        spawnerTemp.y += obstacleSpawnerDistance;
        transform.position = spawnerTemp;

        spawnedLargeCircle = false;

    }


} // class






























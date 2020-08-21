using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "Cyan" || target.tag == "Yellow" ||
            target.tag == "Pink" || target.tag == "Magenta")
        {

            target.gameObject.transform.parent.gameObject.SetActive(false);

        }

    }

}

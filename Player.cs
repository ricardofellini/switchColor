using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jumpForce = 8f;

    private Rigidbody2D myBody;
    private SpriteRenderer sr;

    private string currentColor;

    public Color cyanColor, yellowColor, magentaColor, pinkColor;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Use this for initialization
    void Start()
    {
        SetRandomColor();
    }

    void Update()
    {

        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {

            myBody.velocity = Vector2.up * jumpForce;

        }

    }

    void SetRandomColor()
    {

        int index = Random.Range(0, 4);

        switch (index)
        {

            case 0:
                currentColor = "Cyan";
                sr.color = cyanColor;
                break;

            case 1:
                currentColor = "Yellow";
                sr.color = yellowColor;
                break;

            case 2:
                currentColor = "Pink";
                sr.color = pinkColor;
                break;

            case 3:
                currentColor = "Magenta";
                sr.color = magentaColor;
                break;

        }


    }

    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "ChangeColor")
        {

            SetRandomColor();
            target.gameObject.SetActive(false);

            return;

        }

        if (target.tag != currentColor)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }

    }

} // class
































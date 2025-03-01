using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    string String = "World";
    int HELLO = 3;
    Rigidbody2D rb;
    public int speed = 5;
    public String nextLevel = "Scene_2";
    public String nextLevel3 = "Scene_3";

    public NewBehaviourScript(string nextLevel)
    {
        this.nextLevel = nextLevel;
        this.nextLevel = nextLevel3;
    }

    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("Hello World");
        string String2 = "World";
       // Debug.Log(String + String2);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(HELLO);
        HELLO++;


        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Death");
      switch (collision.tag)
        {
            case "Death":
                {
                   string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                   break;
                }

            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }


        }
    

    }
} 
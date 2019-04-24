using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float speed = 5.0f;
     public static int score;
     public static int highScore;
    private string key;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt(key, 0);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey ("up"))
        {*/
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
     /*       Debug.Log("Go");
        }
        if (Input.GetKey("down"))
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
            Debug.Log("Back");
        }*/
        if (Input.GetKey("left"))
        {
            transform.position += new Vector3(-speed*Time.deltaTime,0,0);
            Debug.Log("left");
        }
        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            Debug.Log("right");
        }
        if (this.transform.position.y < -3f)
        {
            if (score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt(key, highScore);
            }
            SceneManager.LoadScene("GameOver");
        }
    }
}

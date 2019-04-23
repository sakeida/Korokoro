using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour {

    public Text scoreText;
    public Text HighScoreText;
	// Use this for initialization
	void Start () {
        scoreText.text = "Your Score : " + PlayerController.score.ToString();
        HighScoreText.text="High Score : "+PlayerController.highScore.ToString();
    }
	
	// Update is called once per frame
	void Update () {

	}
    public void restartButton()
    {
        SceneManager.LoadScene("Stage");
    }
}

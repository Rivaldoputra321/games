using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text scoreText;

    private int score = 0;
    void Awake()
    {
        scoreText = GameObject.Find ("ScoreText").GetComponent<Text> ();
        scoreText.text = "0";
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "trash"){
            target.gameObject.SetActive (false);
            score++;
            scoreText.text = score.ToString ();
        }
    }
    

    
}
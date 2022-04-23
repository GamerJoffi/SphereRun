using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreAndHigh : MonoBehaviour
{
    public Leaderboard leaderboard;

    public float scoreTime = 1;
    public float timer = 0;

    public float Score;
    public float highscore;

    public int ausgabe = 0;

    public int highscored;

    public int testint = 30;
    public Text scoreText;
    public Text highscoreText;


    public void Start()
    {
        highscore = PlayerPrefs.GetFloat("Highscore");



        Debug.Log("my int = " + testint);
    }



    public void Update()
    {

        if (ausgabe < highscore)
        {
            ausgabe++;
        }

        Debug.Log(ausgabe);

        highscore = PlayerPrefs.GetFloat("Highscore");
        scoreText.text = Score.ToString();
        highscoreText.text = highscore.ToString("Hi: 0");


        if (timer > scoreTime)
        {

            Score++;
            timer = 0;
        }

        if(Score> highscore)
        {
            PlayerPrefs.SetFloat("Highscore", Score);
        }

        timer += Time.deltaTime;
    }

    public void ScoreIstNull()
    {

        Score = 0;
    }

    public void SendScore()
    {
        leaderboard.SubmitScoreRoutine(ausgabe);
    }





}

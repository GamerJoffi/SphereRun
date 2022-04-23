using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GooglePlayGames.BasicApi;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverCanvas;

    public GameObject play; 
    public GameObject pause;
   
    public ScoreAndHigh scoreAndHigh;
    public MainMenuScript mainMenuScript;



    private void Awake()
    {
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;


    }



    // Update is called once per frame
    public void GameOver()
    {
        scoreAndHigh.SendScore();
        Destroy(GameObject.FindWithTag("Obstacel"));
        gameOverCanvas.SetActive(true);

        
        //Score wird null Gesetzt bei einem Tod


        Time.timeScale = 0;

    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void Home()
    {
        scoreAndHigh.SendScore();
        mainMenuScript.Home();
    }

    public void Pause1()
    {
        Time.timeScale = 0;
        pause.SetActive(false);
        play.SetActive(true);
    }

    public void Play1()
    {
        Time.timeScale = 1;
        pause.SetActive(true);
        play.SetActive(false);
    }
}

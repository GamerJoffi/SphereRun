using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {



	public GameObject MenuCanvas;

	public GameObject ShopCanvas;

	public GameObject obstacleSpawner;

	public GameObject GameOver;

	public GameObject dunkler;
	
	public GameObject scores;

	public GameObject play;
	public GameObject pause;

	public ScoreAndHigh scoreAndHigh;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame()
	{
		MenuCanvas.SetActive(false);

		ShopCanvas.SetActive(false);

		obstacleSpawner.SetActive(true);

		pause.SetActive(true);

		play.SetActive(false);

		dunkler.SetActive(false);
		scores.SetActive(false);

		scoreAndHigh.ScoreIstNull();

		Time.timeScale = 1;

	}

	public void QuitGame()
	{
		// Spiel beenden
		Application.Quit();
	}

	public void Home()
    {
		MenuCanvas.SetActive(true);

		obstacleSpawner.SetActive(false);

		GameOver.SetActive(false);

		pause.SetActive(false);

		play.SetActive(false);

		ShopCanvas.SetActive(false);

		dunkler.SetActive(true);

		scoreAndHigh.SendScore();

		Time.timeScale = 0;

	}

	public void ShopAuf()
    {
		MenuCanvas.SetActive(false);

		ShopCanvas.SetActive(true);
	}

	public void scores1()
    {
		scores.SetActive(true);
	}
	
	public void nachhause()
    {
		MenuCanvas.SetActive(true);

		obstacleSpawner.SetActive(false);

		GameOver.SetActive(false);

		pause.SetActive(false);

		play.SetActive(false);

		ShopCanvas.SetActive(false);

		dunkler.SetActive(true);

		scores.SetActive(false);
	}

	public void openScore()
    {
		MenuCanvas.SetActive(false);

		obstacleSpawner.SetActive(false);

		GameOver.SetActive(false);

		pause.SetActive(false);

		play.SetActive(false);

		ShopCanvas.SetActive(false);

		dunkler.SetActive(true);

		scores.SetActive(true);

		scoreAndHigh.SendScore();
	}
}

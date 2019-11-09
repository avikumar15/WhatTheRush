using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuPrac : MonoBehaviour
{
	public static bool GameIsPauesed = false;
	public GameObject pauseMenu;
	public GameObject GameDone;
	int choice;

	public Button resume;
	public Button restart;
	public Button menu;
	public Button exit;

	int entered;

	private void Start()
	{
		GameDone.SetActive(false);
		choice = 0;
		entered = 0;
		resume.Select();
	}

	// Update is called once per frame
	void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(GameIsPauesed)
			{
				entered = 0;
				Resume();
			}
			else
			{
				entered = 1;
				Pause();
			}
		}

		if(entered==1)
		{
			if (Input.GetKeyUp(KeyCode.DownArrow))
			{
				choice++;
			}
			if (Input.GetKeyUp(KeyCode.UpArrow))
			{
				choice--;
			}

			switch (choice % 4)
			{
				case 0:
					{
						resume.Select();
						Debug.Log("FirstChoice");
						break;
					}

				case 1:
					{
						restart.Select();
						Debug.Log("SecondChoice");
						break;
					}

				case 2:
					{
						menu.Select();
						Debug.Log("ThirdChoice");
						break;
					}

				case 3:
					{
						exit.Select();
						Debug.Log("LstChoice");
						break;
					}
			}
		}
    }

	public void Resume()
	{
		Debug.Log("Entered Resume() where timescale is becoming 1");
		pauseMenu.SetActive(false);
		Time.timeScale = 1f;
		GameIsPauesed = false;
	}

	public void Pause ()
	{
		Debug.Log("Entered Pause() where timescale is becoming 0");
		pauseMenu.SetActive(true);
		Time.timeScale = 0f;
		GameIsPauesed = true;
	}

	public void Restart()
	{
		Debug.Log("Restarting");
		Time.timeScale = 1f;
		LapTime.Min = 0;
		LapTime.Sec = 0;
		LapTime.Milli = 0;
		LapComplete.lap = 0;
		SceneManager.LoadScene("PracticeMode");
	}

	public void LoadMenu()
	{
		Debug.Log("Back To Menu");
		Time.timeScale = 1f;
		LapTime.Min = 0;
		LapTime.Sec = 0;
		LapTime.Milli = 0;
		SceneManager.LoadScene("StartMenu");
	}

	public void QuitGame()
	{
		Debug.Log("Quitting Game");
		Application.Quit();
	}
}

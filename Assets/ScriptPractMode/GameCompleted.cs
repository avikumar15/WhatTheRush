using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameCompleted : MonoBehaviour
{
	public GameObject GameDoneCanvas;
	public GameObject PrevCanvas;
	public GameObject TheCar;
	public Text TheTimer;

	private void Start()
	{
		PrevCanvas.SetActive(true);
		GameDoneCanvas.SetActive(false);
		Time.timeScale = 1f;
	}

	// Update is called once per frame
	void Update()
    {
		if(LapComplete.lap==3)
		{
			Destroy(TheCar.GetComponent("CarAudio"));
			Debug.Log("Game Completed.");

			PrevCanvas.SetActive(false);
			GameDoneCanvas.SetActive(true);

			Time.timeScale = 0f;
			int rounded = (int) LapComplete.lastmilli;
			TheTimer.text = "0"+LapComplete.lastmin + ":" + LapComplete.lastsec + "." + rounded;

			if((LapComplete.lastmilli + LapComplete.lastsec*100 + LapComplete.lastmin * 6000) < (PlayerPrefs.GetFloat("Highscore", 999999999999999999999999999999f)))
			PlayerPrefs.SetFloat("Highscore", LapComplete.lastmilli + LapComplete.lastsec * 100 + LapComplete.lastmin * 6000);


			if (Input.GetKey(KeyCode.Space))
			{
				Time.timeScale = 1f;
				GameDoneCanvas.SetActive(false);
				LapComplete.lap = 0;
				SceneManager.LoadScene("StartMenu");
			}

			//GameDoneCanvas.SetActive(true);
		}
	}	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PracticeModeIntent : MonoBehaviour
{
	public Button practice;
	public Button race;
	public Button rules;
	public Button Leaderboard;
	public Button exit;

	private int selection=10000;

	public void Start()
	{
		practice.Select();
	}

	public void Update()
	{
		if (Input.GetKeyUp(KeyCode.DownArrow))
			selection++;
		if (Input.GetKeyUp(KeyCode.UpArrow))
			selection--;

		switch (selection%5)
		{
			case 0:
				practice.Select();
				break;

			case 1:
				race.Select();
				break;

			case 2:
				rules.Select();
				break;

			case 3:
				Leaderboard.Select();
				break;

			case 4:
				exit.Select();
				break;

		}
	}

	public void PracticeMode(string NewPracticeMode)
	{
		Debug.Log("Launching Practice mode");
		SceneManager.LoadScene(NewPracticeMode);
	}

	public void OpenRules()
	{
		Debug.Log("Launching Rules");
		SceneManager.LoadScene("Rules");
	}

	public void OpenStats()
	{
		Debug.Log("Opening Stats");
		SceneManager.LoadScene("stats");
	}

	public void StartRaceMode()
	{
		Debug.Log("Starting Race Mode");
		SceneManager.LoadScene("RaceMode");
	}

}

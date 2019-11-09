using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpRace : MonoBehaviour
{
	public GameObject TheCar;

	public GameObject HeightCanvas;
	public Text Height;

	//public GameObject LapCanvas;

	public static int jump;

	void Start()
	{
		Time.timeScale = 1f;
		jump = 0;
		HeightCanvas.SetActive(false);
	}

	void Update()
	{
		if (TheCar.transform.position.y >= 18)
		{
			jump = 1;
		//	LapCanvas.SetActive(false);
			Time.timeScale = 0.5f;
			HeightCanvas.SetActive(true);
			Debug.Log("Height is greater than threshold!");
			Height.text = "Jump Height - " + (TheCar.transform.position.y) + "m";
			CanvasLapDisple.param = 0;
		}
		else
		{
		//	LapCanvas.SetActive(true);
			Time.timeScale = 1f;
			HeightCanvas.SetActive(false);
		}
		
				if(PauseMenuRace.GameIsPauesed)
				{
					Time.timeScale = 0f;
					HeightCanvas.SetActive(false);
				//	LapCanvas.SetActive(false);
				}
				else
				{
					Time.timeScale = 1f;
				//	LapCanvas.SetActive(true);
				}

		if (CanvasLapDisple.lapCount >= 1)
			Time.timeScale = 0f;
	}

}
	

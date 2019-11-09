using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HalfPointTriggerRace : MonoBehaviour
{
	public GameObject HalfPoint;
	public GameObject FullPoint;

	public GameObject GameCompRace;
	public GameObject backCanvas;

	public void Start()
	{
		GameCompRace.SetActive(false);
	}

	public void OnTriggerEnter(Collider collider)
	{
		if(collider.tag == "Player")
		{
			HalfPoint.SetActive(false);
			FullPoint.SetActive(true);
		}
	}

	private void Update()
	{
		if (LapCompleteTriggerRace.gamedone == 1)
		{
			backCanvas.SetActive(false);

			if (Input.GetKey(KeyCode.Space))
			{
				Debug.Log("Space Entered");
				CanvasLapDisple.lapCount = 0;
				CanvasLapDisple.Milli = 0;
				CanvasLapDisple.Min = 0;
				CanvasLapDisple.Sec = 0;
				LapCompleteTriggerRace.bestmilliint = 0;
				LapCompleteTriggerRace.bestminint = 0;
				LapCompleteTriggerRace.bestmilliint = 0;
				SceneManager.LoadScene("StartMenu");
			}
		}
	}
}

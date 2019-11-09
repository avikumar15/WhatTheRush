using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LapCompleteTriggerRace : MonoBehaviour
{
	public GameObject FullPoint;
	public GameObject HalfPoint;

	public Text bestmin;
	public Text bestsec;
	public Text bestmilli;
	public Text Verdict;

	public static int bestminint;
	public static int bestsecint;
	public static int bestmilliint;

	public GameObject GameCompRace;
	public GameObject BackgroundCanvas;
	public Text FinalBestTime;

	public static int gamedone;

	private void Start()
	{
		gamedone = 0;
		GameCompRace.SetActive(false);
	}

	public void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Player")
		{
			FullPoint.SetActive(false);
			HalfPoint.SetActive(true);

			CanvasLapDisple.lapCount++;
			if(CanvasLapDisple.lapCount == 1 || (CanvasLapDisple.Milli + CanvasLapDisple.Sec * 100 + CanvasLapDisple.Min * 6000)<(bestmilliint +bestsecint*100 +bestminint*6000))
			{
				bestmilliint = (int) CanvasLapDisple.Milli;
				bestminint = CanvasLapDisple.Min;
				bestsecint = CanvasLapDisple.Sec;

				bestmin.text = "0"+bestminint.ToString()+":";
				if(bestsecint>=10)
				bestsec.text = bestsecint.ToString()+".";
				else
					bestsec.text = "0"+bestsecint.ToString() + ".";
				bestmilli.text = bestmilliint.ToString();

				CanvasLapDisple.Milli = 0;
				CanvasLapDisple.Sec = 0;
				CanvasLapDisple.Min = 0;

				if(CanvasLapDisple.lapCount>=3)
				{
					if (CanvasLapDisple.lapCount > AIfulltrigger.lapAI)
					{
						Verdict.text = "Game Won";
						Debug.Log("WON");
					}
					else
					{ Debug.Log("LOST");
						Verdict.text = "Game Lost";
					}
					Debug.Log("Entered game ending condition and lapcount is " + CanvasLapDisple.lapCount);
					GameCompRace.SetActive(true);
					Time.timeScale = 0f;
					if(bestsecint>=10)
					FinalBestTime.text = "0" + bestminint + ":" + bestsecint + "." + bestmilliint;
					else FinalBestTime.text = "0" + bestminint + ":" + "0" +bestsecint + "." + bestmilliint;
					BackgroundCanvas.SetActive(false);
					gamedone = 1;
				}
			}
		}
	}

	public void Update()
	{
		if (gamedone == 1)
		{
			BackgroundCanvas.SetActive(false);

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

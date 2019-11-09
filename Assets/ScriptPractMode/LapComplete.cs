using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
	public GameObject MiddleTrig;
	public GameObject LapCompleteTrig;
	public GameObject CANVAStoGO;

	public Text MinuteSet;
	public Text SecSet;
	public Text MilliSet;
	public Text LapNo;

	public static int lastmin;
	public static int lastsec;
	public static float lastmilli;

	public static int lap=0;

	public GameObject LapTimeBox;

	public GameObject GameDone;

	private void Start()
	{
		Debug.Log("Entered LapComplete.cs");
		GameDone.SetActive(false);
	//	lap = 0;

	//	LapTime.Sec = 0;
	//	LapTime.Min = 0;		don't add or else timer restarts at halftrigger
	//	LapTime.Milli = 0;
	}

	private void Update()
	{
		if (lap >= 3)
			CANVAStoGO.SetActive(false);
	}

	// Update is called once per frame
	void OnTriggerEnter()
	{
			Debug.Log("Entered OnTriggered of LapComplete and value of lap : "+lap);
	
		lap++;


		LapNo.text = "" + lap.ToString();
		if ((LapTime.Min * 60 * 100 + LapTime.Sec * 100 + LapTime.Milli) < (lastmin * 6000 + lastsec * 100 + lastmilli) || lap==1)
		{
			if (LapTime.Min > 9)
			{
				lastmin = LapTime.Min;
				MinuteSet.text = LapTime.Min.ToString() + ": ";
			}
			else
			{
				lastmin = LapTime.Min;
				MinuteSet.text = "0" + LapTime.Min.ToString() + ": ";
			}
			if (LapTime.Sec > 9)
			{
				lastsec = LapTime.Sec;
				SecSet.text = LapTime.Sec.ToString() + ".";
			}
			else
			{
				lastsec = LapTime.Sec;
				SecSet.text = "0" + LapTime.Sec.ToString() + ".";
			}
			if (LapTime.Milli > 9)
			{
				MilliSet.text = LapTime.Milli.ToString();
				lastmilli = LapTime.Milli;
			}
			else
			{
				lastmilli = LapTime.Milli;
				MilliSet.text = "0" + LapTime.Milli.ToString();

			}
		}

		LapTime.bestlapgame =(lastmilli + lastsec * 100 + lastmin * 6000);

		if(LapTime.bestlapgame<PlayerPrefs.GetFloat("BestLap", 999999999999999999999999.0f))
		{
			PlayerPrefs.SetFloat("BestLap", LapTime.bestlapgame);
		}

		LapTime.Sec = 0;
		LapTime.Min = 0;
		LapTime.Milli = 0;

		MiddleTrig.SetActive(true);
		LapCompleteTrig.SetActive(false);

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTime : MonoBehaviour
{
	public static int Min=0;
	public static int Sec=0;
	public static float Milli=0;
	public static string MilliDisp;
	float count = 3;
	static float timer = 0;

	public Text MinuteBox;
	public Text SecBox;
	public Text MilliBox;
	public Text Countdown;

	public GameObject GameDone;

	public static float bestlapgame;

	public GameObject TheCar;
	public bool nitroactivated;

	//	public GameObject CANVAStoGO;

	private void Start()
	{
		Countdown.text = "3";
		//Time.timeScale = 0.5f;

		GameDone.SetActive(false);

		timer = 0;
		timer = timer + Time.deltaTime * 100;

	//	Debug.Log(timer);

		if (timer <= 100)
		{
			count = 3;
			Countdown.text = "" + count;
		}
		else if (timer <= 200)
		{
			count = 2;
			Countdown.text = "" + count;
		}
		else if (timer < 300)
		{
			count = 1;
			Countdown.text = "1";
		}
		else if (timer < 310)
			Countdown.text = "GO";
		else
			Countdown.text = "";
	}
	void Update()
    {

		Countdown.text = "3";
		//Time.timeScale = 0.5f;

		timer = timer + Time.deltaTime * 100;
		//Debug.Log(timer);

		if (timer <= 100)
		{
			count = 3;
			Countdown.text = "" + count;
		}
		else if (timer <= 200)
		{
			count = 2;
			Countdown.text = "" + count;
		}
		else if (timer < 300)
		{
			count = 1;
			Countdown.text = "1";
		}
		else if (timer < 410)
			Countdown.text = "GO!";
		else
			Countdown.text = "";

		if(Input.GetKeyDown(KeyCode.N) && !nitroactivated)
		{
			Debug.Log("Nitro Activated");
			TheCar.GetComponent<Rigidbody>().drag = 0.1f;
			TheCar.GetComponent<Rigidbody>().drag = 0.01f;
			nitroactivated = true;
		}

		if (Input.GetKeyDown(KeyCode.N) && nitroactivated)
		{
			Debug.Log("Nitro DeActivated");
			TheCar.GetComponent<Rigidbody>().drag = 0.2f;
			TheCar.GetComponent<Rigidbody>().drag = 0.05f;
			nitroactivated = false;
		}

		StartCoroutine(Example());
	}

	IEnumerator Example()
	{
		yield return new WaitForSeconds(4f);

		//Time.timeScale = 1f;

		Countdown.text = "";
		Milli = Milli + Time.deltaTime * 100;
		MilliDisp = Milli.ToString("F0");

		if (Milli < 100)
		{
			if (Milli >= 10)
				MilliBox.text = "" + MilliDisp;
			else
				MilliBox.text = "0" + MilliDisp;
		}
		else
		{
			Milli = 0;
			MilliBox.text = "00";
			Sec = Sec + 1;
		}

		if (Sec < 60)
		{
			if (Sec >= 10)
				SecBox.text = "" + Sec.ToString() + ".";
			else
				SecBox.text = "0" + Sec.ToString() + ".";
		}
		else
		{
			SecBox.text = "00.";
			Sec = 0;
			Min = Min + 1;
		}

		if (Min >= 10)
			MinuteBox.text = "" + Min.ToString() + ":";
		else
			MinuteBox.text = "0" + Min.ToString() + ":";

	}
	}
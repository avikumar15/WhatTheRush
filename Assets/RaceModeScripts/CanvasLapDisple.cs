using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasLapDisple : MonoBehaviour
{
	public static int Min = 0;
	public static int Sec = 0;
	public static float Milli = 0;
	public static int lapCount;

	float count = 3;
	static float timer = 0;

	public Text MinuteBox;
	public Text SecBox;
	public Text MilliBox;
	public Text Countdown;
	public Text LapNo;

	public GameObject TheLapDisplayCanvas;

	public GameObject TheCar;
	public GameObject TheAICar;

	public static int param;

	//public GameObject GameDone;

	//public static float bestlapgame;

	// Start is called before the first frame update
	void Start()
    {
		lapCount = 0;
		count = 3;
		Min = 0;
		Sec = 0;
		Milli = 0;
		timer = 0;

		param = 1;

		TheLapDisplayCanvas.SetActive(true);

		Countdown.text = "3";

		StartCoroutine(Example2());

	}

	// Update is called once per frame
	void Update()
    {
		LapNo.text = lapCount.ToString();

		timer = timer + Time.deltaTime * 100;
		//Debug.Log(timer);
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

		StartCoroutine(Example(param));

	}

	IEnumerator Example2()

	{
		yield return new WaitForSeconds(2.8f);

		TheCar.transform.position = new Vector3(241.17f, 15f, 103f);
		TheAICar.transform.position = new Vector3(241.3f, 15f, 109f);

	}
	IEnumerator Example(int A)
	{
		if (A == 1)
		{
			yield return new WaitForSeconds(3.5f);
		//	TheCar.transform.position = new Vector3(241.17f, 15f, 103f);
		//	TheAICar.transform.position = new Vector3(241.3f, 15f, 109f);
		}
		else
			yield return new WaitForSeconds(0f);


		//Debug.Log("Inside time lag");


		Countdown.text = "";
		Milli = Milli + Time.deltaTime * 100;

		if (Milli < 100)
		{
			if (Milli >= 10)
				MilliBox.text = "" + Milli.ToString();
			else
				MilliBox.text = "0" + Milli.ToString();
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

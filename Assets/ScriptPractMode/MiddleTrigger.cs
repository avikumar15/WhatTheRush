using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTrigger : MonoBehaviour
{
	public GameObject LapComplete;
	public GameObject HalfLapComplete;
	public GameObject GameDone;

	private void Start()
	{
		GameDone.SetActive(false);
	}

	void OnTriggerEnter()
	{
		Debug.Log("MiddleTrigger Reached");
		HalfLapComplete.SetActive(false);
		LapComplete.SetActive(true);
	}
}

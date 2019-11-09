using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIhalfLap : MonoBehaviour
{
	public GameObject halfAI;
	public GameObject fullAI;

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "AI")
		{
			fullAI.SetActive(true);
			halfAI.SetActive(false);
		}
	}
}

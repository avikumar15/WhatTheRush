using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIfulltrigger : MonoBehaviour
{
	public GameObject FULLtrigAI;
	public GameObject HALFTRIGAI;

	public static int lapAI = 0;


	private void OnTriggerEnter(Collider other)
	{
		if(other.tag=="AI")
		{
			lapAI++;

			FULLtrigAI.SetActive(false);
			HALFTRIGAI.SetActive(true);
		}
	}

}

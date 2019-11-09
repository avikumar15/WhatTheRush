using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverRace : MonoBehaviour
{
	public GameObject TheCar;

    // Update is called once per frame
    void Update()
    {
        if(TheCar.transform.position.y <= 1.3)
		{
			StartCoroutine(Example());
		}
    }

	IEnumerator Example()
	{
		yield return new WaitForSeconds(1.5f);
		{
			CanvasLapDisple.lapCount = 0;
			CanvasLapDisple.Milli = 0;
			CanvasLapDisple.Min = 0;
			CanvasLapDisple.Sec = 0;
			LapCompleteTriggerRace.bestmilliint = 0;
			LapCompleteTriggerRace.bestminint = 0;
			LapCompleteTriggerRace.bestmilliint = 0;
			Debug.Log("Game Over");
			SceneManager.LoadScene("GameOverPract");
		}

	}

}

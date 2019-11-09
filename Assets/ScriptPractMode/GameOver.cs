using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
	public GameObject GameDone;
	public GameObject TheCar;
	private void Start()
	{
		GameDone.SetActive(false);
	}
	// Update is called once per frame
	void Update()
    {
		if (TheCar.transform.position.y <= 1.3)
		{
			StartCoroutine(Example());
		}
		}

	IEnumerator Example()
	{
		yield return new WaitForSeconds(1.5f);
		{
			LapComplete.lap = 0;
			LapComplete.lastmilli = 0;
			LapComplete.lastmin = 0;
			LapComplete.lastsec = 0;
			LapTime.Sec = 0;
			LapTime.Min = 0;
			LapTime.Milli = 0;
			Debug.Log("Game Over");
			SceneManager.LoadScene("GameOverPract");
		}

	}
}

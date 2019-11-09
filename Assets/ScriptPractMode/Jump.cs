using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{

	public GameObject TheCar;

	public GameObject HeightCanvas;
	public Text Height;


	public GameObject GameDone;


	// Start is called before the first frame update
	void Start()
    {
		Time.timeScale = 1f;
		GameDone.SetActive(false);
		HeightCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		if (TheCar.transform.position.y >= 18)
		{
			Time.timeScale = 0.5f;
			HeightCanvas.SetActive(true);
			Height.text = "Jump Height - " + (TheCar.transform.position.y) + "m";
		}
		else if(!PauseMenuPrac.GameIsPauesed)
		{
			Time.timeScale = 1f;
			HeightCanvas.SetActive(false);
		}
	}
}

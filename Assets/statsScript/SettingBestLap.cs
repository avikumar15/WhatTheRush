using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingBestLap : MonoBehaviour
{
	public Text TheBestLap;
	float ANS;

    // Start is called before the first frame update
    void Start()
    {
		ANS = PlayerPrefs.GetFloat("HighScore", LapTime.bestlapgame);
		if(((ANS % 6000) / 100)>10)
		TheBestLap.text = "0"+(ANS/6000).ToString()+":"+((ANS%6000)/100).ToString()+"."+((ANS%6000)%100).ToString();
		else
			TheBestLap.text = "0" + (ANS / 6000).ToString() + ":0" + ((ANS % 6000) / 100).ToString() + "." + ((ANS % 6000) % 100).ToString();
	}

	// Update is called once per frame
	void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
		{
			SceneManager.LoadScene("StartMenu");
		}
    }
}

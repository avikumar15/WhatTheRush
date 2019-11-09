using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackFromRules : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			Debug.Log("Going Back");
			SceneManager.LoadScene("StartMenu");
		}
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
		{
			Debug.Log("Going Back");
			SceneManager.LoadScene("StartMenu");
		}
    }
}

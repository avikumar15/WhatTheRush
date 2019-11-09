using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
	public GameObject[] obstacles;
	//int[] obstacleNumber;
	int i = 0;
	//int count = 0;
	int rand;
	Vector3 size;
	int check;

	private string[] AddObs;
	private int index;

	// Start is called before the first frame update
	void Start()
    {
		check = 1;
		index = 0;
		AddObs = new string[] { "w", "h", "a", "t", "t", "h", "e", "f", "u", "s", "s" };

		for (i=0;i<90;i++)
		{
			rand = UnityEngine.Random.Range(0, 2);
			if(rand == 1)
			{
				obstacles[i].SetActive(true);
				obstacles[i].transform.localScale = new Vector3(obstacles[i].transform.localScale.x - UnityEngine.Random.Range(0,2), obstacles[1].transform.localScale.y - UnityEngine.Random.Range(0, 5), obstacles[1].transform.localScale.z - UnityEngine.Random.Range(0, 2));		
			}
			else
			{
				obstacles[i].SetActive(false);
			}
		}
		//Debug.Log("Obstacle position is : " + obstacles[1].transform.position.z);
		//Vector3 newPos = new Vector3(obstacles[1].transform.position.x, obstacles[1].transform.position.y, obstacles[1].transform.position.z-40);
		//obstacles[1].transform.position = newPos;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.H) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.T) || Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.S))
		{
			try
			// Check if the next key in the code is pressed
			{
				if (Input.GetKeyDown(AddObs[index]))
				{
					// Add 1 to index to check the next key in the code
					index++;

				}
				// Wrong key entered, we reset code typing
				else
				{
					index = 0;
				}
			}
			catch (InvalidCastException e)
			{
				Debug.Log("Can't enter cheat");
			}
		}

		if (index == AddObs.Length && check==1)
		{
			{
				Debug.Log("What the fuss?");
				// Cheat code successfully inputted!
				// Unlock crazy cheat code stuff
			for (i = 0; (i < 90); i++)
				{
					check = 0;
					rand = UnityEngine.Random.Range(0, 2);
					if (rand != 1)
					{
						obstacles[i].SetActive(true);
					}
				}
				index = 0;
			}
			}
	}
}

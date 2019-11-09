using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour
{
	public GameObject TheAICar;
	public GameObject TheMarker;

	public GameObject Mark01;
	public GameObject Mark02;
	public GameObject Mark03;
	public GameObject Mark04;
	public GameObject Mark05;
	public GameObject Mark06;
	public GameObject Mark07;
	public GameObject Mark08;
	public GameObject Mark09;
	public GameObject Mark10;
	public GameObject Mark11;
	public GameObject Mark12;
	public GameObject Mark13;
	public GameObject Mark14;
	public GameObject Mark15;
	public GameObject Mark16;
	public GameObject Mark17;
	public GameObject Mark18;
	public GameObject Mark19;
	public GameObject Mark20;
	public GameObject Mark21;
	public GameObject Mark22;
	public GameObject Mark23;
	public GameObject Mark24;
	public GameObject Mark25;
	public GameObject Mark26;
	public GameObject Mark27;
	public GameObject Mark28;
	public GameObject Mark29;
	public GameObject Mark30;
	public GameObject Mark31;
	public GameObject Mark32;
	public GameObject Mark33;
	public GameObject Mark34;
	public GameObject Mark35;
	public GameObject Mark36;
	public GameObject Mark37;
	public GameObject Mark38;
	public GameObject Mark39;
	public GameObject Mark40;
	public GameObject Mark41;
	public GameObject Mark42;

	public int MarkTracker;

	void Update()
    {
        if(MarkTracker==0) {
		//	Debug.Log("MarkTracker is 0");
			//MarkTracker++;
			TheMarker.transform.position = Mark01.transform.position;
		}
		if (MarkTracker == 1)
		{
		//	Debug.Log("MarkTracker is 1");
			TheMarker.transform.position = Mark02.transform.position;
			TheMarker.transform.localScale = new Vector3(30, 30, 30);
			//MarkTracker++;
		}
		if (MarkTracker == 2)
		{
		//	Debug.Log("MarkTracker is 2");
			TheMarker.transform.position = Mark03.transform.position;
		}
		if (MarkTracker == 3)
		{
			TheMarker.transform.position = Mark04.transform.position;
		}
		if (MarkTracker == 4)
		{
			TheMarker.transform.position = Mark05.transform.position;
		}
		if (MarkTracker == 5)
		{
			TheMarker.transform.position = Mark06.transform.position;
		}
		if (MarkTracker == 6)
		{
			//	Debug.Log("MarkTracker is 1");
			TheMarker.transform.position = Mark07.transform.position;
			//MarkTracker++;
		}
		if (MarkTracker == 7)
		{
			//	Debug.Log("MarkTracker is 2");
			TheMarker.transform.position = Mark08.transform.position;
		}
		if (MarkTracker == 8)
		{
			TheMarker.transform.position = Mark09.transform.position;
		}
		if (MarkTracker == 9)
		{
			TheMarker.transform.position = Mark10.transform.position;
		}
		if (MarkTracker == 10)
		{
			TheMarker.transform.position = Mark11.transform.position;
		}

		if (MarkTracker == 11)
		{
			//	Debug.Log("MarkTracker is 1");
			TheMarker.transform.position = Mark12.transform.position;
			//MarkTracker++;
		}
		if (MarkTracker == 12)
		{
			//	Debug.Log("MarkTracker is 2");
			TheMarker.transform.position = Mark13.transform.position;
		}
		if (MarkTracker == 13)
		{
			TheMarker.transform.position = Mark14.transform.position;
		}
		if (MarkTracker == 14)
		{
			TheMarker.transform.position = Mark15.transform.position;
		}
		if (MarkTracker == 15)
		{
			TheMarker.transform.position = Mark16.transform.position;
		}
		if (MarkTracker == 16)
		{
			//	Debug.Log("MarkTracker is 1");
			TheMarker.transform.position = Mark17.transform.position;
			TheAICar.GetComponent<Rigidbody>().drag = 0.05f;
			TheAICar.GetComponent<Rigidbody>().angularDrag = 0.05f;
			Debug.Log("Changed drag and stuff!");
			//MarkTracker++;
		}
		if (MarkTracker == 17)
		{
			//	Debug.Log("MarkTracker is 2");
			TheMarker.transform.position = Mark18.transform.position;
		}
		if (MarkTracker == 18)
		{
			TheMarker.transform.position = Mark19.transform.position;
			TheAICar.GetComponent<Rigidbody>().drag = 0.2f;
			TheAICar.GetComponent<Rigidbody>().angularDrag = 0.2f;
			Debug.Log("Changed drag and stuff, again!");
		}
		if (MarkTracker == 19)
		{
			TheMarker.transform.position = Mark20.transform.position;
		}
		if (MarkTracker == 20)
		{
			TheMarker.transform.position = Mark21.transform.position;
			//TheMarker.transform.localScale = new Vector3(15, 15, 15);
		}

		if (MarkTracker == 21)
		{
			TheMarker.transform.position = Mark22.transform.position;
		}

		if (MarkTracker == 22)
		{
			TheMarker.transform.position = Mark23.transform.position;
		}

		if (MarkTracker == 23)
		{
			//	Debug.Log("MarkTracker is 1");
			TheMarker.transform.position = Mark24.transform.position;
			//MarkTracker++;
		}
		if (MarkTracker == 24)
		{
			//	Debug.Log("MarkTracker is 2");
			TheMarker.transform.position = Mark25.transform.position;
		}
		if (MarkTracker == 25)
		{
			TheMarker.transform.position = Mark26.transform.position;
		}

		if (MarkTracker == 26)
		{
			TheMarker.transform.position = Mark27.transform.position;
			//TheMarker.transform.localScale = new Vector3(10, 10, 10);
		}

		if (MarkTracker == 27)
		{
			TheMarker.transform.position = Mark28.transform.position;
		}

		if(MarkTracker == 28)
		{
			TheMarker.transform.position = Mark29.transform.position;
		}

		if (MarkTracker == 29)
		{
			//	Debug.Log("MarkTracker is 1");
			TheMarker.transform.position = Mark30.transform.position;
			//MarkTracker++;
		}
		if (MarkTracker == 30)
		{
			//	Debug.Log("MarkTracker is 2");
			TheMarker.transform.position = Mark31.transform.position;
		}


		if (MarkTracker == 31)
		{
			//	Debug.Log("MarkTracker is 1");
			TheMarker.transform.position = Mark32.transform.position;
			//MarkTracker++;
		}
		if (MarkTracker == 32)
		{
			//	Debug.Log("MarkTracker is 2");
			TheMarker.transform.position = Mark33.transform.position;
		}
		if (MarkTracker == 33)
		{
			TheMarker.transform.position = Mark34.transform.position;
		}
		if (MarkTracker == 34)
		{
			TheMarker.transform.position = Mark35.transform.position;
		}
		if (MarkTracker == 35)
		{
			TheMarker.transform.position = Mark36.transform.position;
		}
		if (MarkTracker == 36)
		{
			//	Debug.Log("MarkTracker is 1");
			TheMarker.transform.position = Mark37.transform.position;
			//MarkTracker++;
		}
		if (MarkTracker == 37)
		{
			//	Debug.Log("MarkTracker is 2");
			TheMarker.transform.position = Mark38.transform.position;
		}
		if (MarkTracker == 38)
		{
			TheMarker.transform.position = Mark39.transform.position;
		}
		if (MarkTracker == 39)
		{
			TheMarker.transform.position = Mark40.transform.position;
		}
		if (MarkTracker == 40)
		{
			TheMarker.transform.position = Mark41.transform.position;
		}
		if (MarkTracker == 41)
		{
			TheMarker.transform.position = Mark42.transform.position;
		}
		if (MarkTracker == 42)
		{
			TheMarker.transform.position = Mark01.transform.position;
		}

	}

	IEnumerator OnTriggerEnter(Collider collision)
	{
		Debug.Log("OnTriggerEnter");
		if(collision.gameObject.tag == "AI")
		{
			Debug.Log("MarkTracker is incremented"+MarkTracker);
			this.GetComponent<BoxCollider>().enabled = false;
			MarkTracker++;

			if (MarkTracker == 42)
				MarkTracker = 0;
		}
		yield return new WaitForSeconds(1f);

		this.GetComponent<BoxCollider>().enabled = true;
	}

}

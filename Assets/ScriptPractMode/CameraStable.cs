using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour
{
	// Start is called before the first frame update

	public GameObject TheCar;

	public float CarX;
	public float CarY;
	public float CarZ;

	public GameObject GameDone;
	private void Start()
	{
		GameDone.SetActive(false);
	}
	// Update is called once per frame
	void Update()
    {
		CarX = TheCar.transform.eulerAngles.x;
		CarY = TheCar.transform.eulerAngles.y;
		CarZ = TheCar.transform.eulerAngles.z;

		transform.eulerAngles = new Vector3(0, CarY, 0);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchManager : MonoBehaviour {
	public List<GameObject> listCamera = new List<GameObject>();
	int index;

	void Start () {
		index = 0;
		ToggleCamera(index);
	}

	int idx;
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.I))
		{
			//0 -> 1 -> 2 -> 3 -> 4 -> 5....
			//0    1    2    3    0 -> 1 2 3 0 1 2 3 0
			//int /float  => float
			//int /int => int
			//      /    %
			//0/4 = 0    0
			//1/4 = 0.25 1
			//2/4 = 0.5  2
			//3/4 = 0.75 3
			//4/4 = 1    0
			//5/4 = 1.25 1
			index++;
			index = index % listCamera.Count;
			ToggleCamera(index);
			///index = index / listCameraSecond.Count;
		}

		if (Input.GetKeyDown(KeyCode.Alpha1)) { index = 0; ToggleCamera(index); }
		else if (Input.GetKeyDown(KeyCode.Alpha2)) { index = 1; ToggleCamera(index); }
		else if (Input.GetKeyDown(KeyCode.Alpha3)) { index = 2; ToggleCamera(index); }
		else if (Input.GetKeyDown(KeyCode.Alpha4)) { index = 3; ToggleCamera(index); }


	}

	void ToggleCamera(int _idx)
	{
		for (int i = 0; i < listCamera.Count; i++)
		{
			if(i == _idx)
				listCamera[i].SetActive(true);
			else
				listCamera[i].SetActive(false);
		}
	}
}

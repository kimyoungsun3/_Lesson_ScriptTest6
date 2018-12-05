using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui_BottomMenu : MonoBehaviour {

	public GameObject cube;
	public void InvokeShow(){
		cube.SetActive (!cube.activeSelf);	

	}
}

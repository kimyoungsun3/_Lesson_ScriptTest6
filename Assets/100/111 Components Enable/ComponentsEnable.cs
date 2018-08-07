using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentsEnable : MonoBehaviour {
	public GameObject target;
	Light light;
	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
		Debug.Log ("SpaceBar : 라이트 ON/OFF");
		Debug.Log ("O : CubeBox On/OFF");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			light.enabled = !light.enabled;
		} else if (Input.GetKeyDown (KeyCode.O)) {
			target.SetActive (!target.activeSelf);
		}
	}
}

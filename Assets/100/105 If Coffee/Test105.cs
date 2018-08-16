using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test105 : MonoBehaviour {
	public float coffeeTemperature;
	public float VERYHOT 	= 120f;
	public float HOT 		= 90f;
	public float GOOD	 	= 40f;
	public float COLD 		= 0f;

	void Start(){
		//Debug.Log ("Coffee is colding");
	}

	void Update(){
		//coffeeTemperature -= Time.deltaTime * 5f;
		coffeeTemperature = coffeeTemperature - Time.deltaTime * 5f;
		TemperatureTest ();
	}

	void TemperatureTest(){
		if (coffeeTemperature > VERYHOT) {
			Debug.Log ("Very hot");
		} else if (coffeeTemperature > HOT) {
			Debug.Log ("hot");
		} else if (coffeeTemperature > GOOD) {
			Debug.Log ("Good");
		} else if (coffeeTemperature > COLD) {
			Debug.Log ("cold");
		} else {
			Debug.Log ("very cold");

		}
	}
}

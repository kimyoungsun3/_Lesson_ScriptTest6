using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorChange : MonoBehaviour {
	public float coffeeTemperature;
	public float HOT 		= 90f;
	public float COLD 		= 0f;
	Renderer renderer;
	Material material;

	void Start(){
		//Debug.Log ("Coffee is colding");
		renderer = GetComponent<Renderer>();
		material = renderer.material;
	}

	void Update(){
		coffeeTemperature -= Time.deltaTime * 5f;
		TemperatureTest ();
	}

	void TemperatureTest(){
		if (coffeeTemperature > HOT) {
			Debug.Log ("hot");
			material.color = Color.red;
		} else if (coffeeTemperature > COLD) {
			Debug.Log ("cold");
			material.color = Color.green;
		} else {
			Debug.Log ("very cold");
			material.color = Color.blue;

		}
	}
}

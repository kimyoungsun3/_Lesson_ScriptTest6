using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorSmoothChange : MonoBehaviour {
	public float coffeeTemperature = 50f;
	public float HOT 		= 45f;
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
		material.color = Color.Lerp(Color.blue, Color.red, coffeeTemperature/50f);
	}
}

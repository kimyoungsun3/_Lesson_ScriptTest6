using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AppleNew a1 = new AppleNew ();
		a1.Chop ();
		a1.SayHello ();

		Fruit f1 = new AppleNew ();
		f1.Chop ();
		f1.SayHello ();		
	}
}

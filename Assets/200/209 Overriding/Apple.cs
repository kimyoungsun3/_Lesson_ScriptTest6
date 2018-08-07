using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit {

	public Apple(){
		Debug.Log ("Apple Constructor");
	}

	public override void Chop(){
		//base.Chop ();
		Debug.Log ("Apple Chop");
	}

	/*
	public override void SayHello(){
		//base.SayHello ();
		Debug.Log ("Apple SayHello");
	}
	*/
}

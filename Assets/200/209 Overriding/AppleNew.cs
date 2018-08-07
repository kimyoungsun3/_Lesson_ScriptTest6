using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleNew : Apple {

	public AppleNew(){
		Debug.Log ("AppleNew Constructor");
	}

	public override void Chop(){
		//base.Chop ();
		Debug.Log ("AppleNew Chop");
	}

	public override void SayHello(){
		//base.SayHello ();
		Debug.Log ("AppleNew SayHello");
	}
}

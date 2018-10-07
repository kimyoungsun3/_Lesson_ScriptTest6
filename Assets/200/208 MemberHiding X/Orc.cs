using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy {
	new public void Yell(){
		//base.Yell ();
		Debug.Log ("Orc");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Humanoid {
	new public void Yell(){
		//base.Yell ();
		Debug.Log ("Enemy");
	}
}

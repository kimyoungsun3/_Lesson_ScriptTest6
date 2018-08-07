using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyTest : MonoBehaviour {
	private int exp_;
	public int exp {
		get { return exp_; 	}
		set { exp_ = value; }
	}
	public int level {
		get {
			Debug.Log ("level 호출하기 전에 작업가능");
			return exp_ / 10; 
		}
	}
	public int healt{ get; set; }


	// Use this for initialization
	void Start () {
		exp = 110;
		healt = 10;

		Debug.Log ("exp : " + exp);
		Debug.Log ("level : " + level);
		Debug.Log ("healt : " + healt);		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTest : MonoBehaviour {
	public int mInt = 0;
	public float mFloat = 10f;
	public Vector3 mVector3;


	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			Func (mInt);
		}
		else if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			Func (mFloat);
		}
		else if (Input.GetKeyDown (KeyCode.Alpha3)) 
		{
			Func (mVector3);
		}		
	}

	void Func(int _x){		Debug.Log ("int:" + _x.ToString());	}
	void Func(float _x){	Debug.Log ("float:" + _x);	}
	void Func(Vector3 _x){	Debug.Log ("V3:" + _x);	}
}

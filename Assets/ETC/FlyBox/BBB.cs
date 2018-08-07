using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BBB {
	//public float TIME_MAX = 60;
	public static float GetTimeInterpolate(float _max){
		return Mathf.Clamp01(Time.time / _max);
	}
}

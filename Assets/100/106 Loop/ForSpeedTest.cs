using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSpeedTest : MonoBehaviour {
	char[] data = new char[16000000];
	float[] t = new float[10]; 
	
	void Update () {
		t[0] = Time.realtimeSinceStartup;
		Fun1(1);
		t[1] = Time.realtimeSinceStartup;
		Fun1(2);
		t[2] = Time.realtimeSinceStartup;
		Fun1(4);
		t[3] = Time.realtimeSinceStartup;
		Fun1(8);
		t[4] = Time.realtimeSinceStartup;
		Fun1(16);
		t[5] = Time.realtimeSinceStartup;
		Fun1(32);
		t[6] = Time.realtimeSinceStartup;
		Fun1(64);
		t[7] = Time.realtimeSinceStartup;

		Debug.Log("=========================");
		Debug.Log("Fun1(1) :" + (t[1] - t[0]));
		Debug.Log("Fun1(2) :" + (t[2] - t[1]));
		Debug.Log("Fun1(4) :" + (t[3] - t[2]));
		Debug.Log("Fun1(8) :" + (t[4] - t[3]));
		Debug.Log("Fun1(16) :" + (t[5] - t[4]));
		Debug.Log("Fun1(32) :" + (t[6] - t[5]));
		Debug.Log("Fun1(64) :" + (t[7] - t[6]));
	}

	void Fun1(int _jump)
	{
		int _len = data.Length;
		int _sum = 0;
		for (int i = 0; i < _len; i += _jump)
		{
			_sum += data[i];
		}
	}
	
}

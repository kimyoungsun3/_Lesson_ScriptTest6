using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringToStringArray : MonoBehaviour {

	// Use this for initialization
	public string[] arrBuf1 = new string[2] { "a1", "a2" };
	public string[] arrBuf2 = new string[2] { "b1", "b2" };
	public string[] arrBuf3 = new string[2] { "c1", "c2" };

	void Start () {
		string _str = "1/2/3";

		Debug.Log("Start4b:" + _str + " > " + arrBuf1.Length);
		Fun1(4, _str, arrBuf1);
		Debug.Log("Start4a:" + _str + " > " + arrBuf1.Length);
		Debug.Log("=====================");

		Debug.Log("Start5b:" + _str + " > " + arrBuf2.Length);
		Fun2(5, ref _str, arrBuf2);
		Debug.Log("Start5a:" + _str + " > " + arrBuf2.Length);
		Debug.Log("=====================");

		Debug.Log("Start6b:" + _str + " > " + arrBuf3.Length);
		Fun3(6, ref _str, ref arrBuf3);
		Debug.Log("Start6a:" + _str + " > " + arrBuf3.Length);
	}

	void Fun1(int _plus, string _str, string[] _strBuff)
	{
		Debug.Log(_strBuff.Length);
		_str += "/" + _plus;
		_strBuff = _str.Split('/');
		Debug.Log("Fun1:" + _plus + " > " + _str + " > " + _strBuff.Length);
	}

	void Fun2(int _plus, ref string _str, string[] _strBuff)
	{
		Debug.Log(_strBuff.Length);
		_str += "/" + _plus;
		_strBuff = _str.Split('/');
		Debug.Log("Fun2:" + _plus + " > " + _str + " > " + _strBuff.Length);
	}

	void Fun3(int _plus, ref string _str, ref string[] _strBuff)
	{
		Debug.Log(_strBuff.Length);
		_str += "/" + _plus;
		_strBuff = _str.Split('/');
		Debug.Log("Fun2:" + _plus + " > " + _str + " > " + _strBuff.Length);
	}

}

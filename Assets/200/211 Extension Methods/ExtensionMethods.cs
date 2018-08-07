using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods {

	public static void XXXReset(this Transform _tran){
		_tran.position = Vector3.zero;
		_tran.rotation = Quaternion.identity;
		_tran.localScale = Vector3.one;
	}

	public static bool XXXDouble(this Transform _tran, float _size){
		_tran.localScale *= _size;

		return true;
	}
}

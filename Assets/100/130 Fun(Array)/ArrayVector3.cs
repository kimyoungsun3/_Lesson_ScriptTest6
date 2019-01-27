using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArrayTest
{
	public class ArrayVector3 : MonoBehaviour
	{

		public Vector3[] array = new Vector3[2];
		void Start()
		{
			Display<Vector3>("Start1", array);
			Fun1(array);
			Display<Vector3>("Start2", array);
		}

		void Fun1(Vector3[] _array)
		{
			Display<Vector3>(" Fun11", _array);
			for (int i = 0; i < _array.Length; i++)
				_array[i] *= 10;
			Display<Vector3>(" Fun12", _array);
		}

		void Display<T>(string _msg, T[] _t)
		{
			for (int i = 0; i < _t.Length; i++)
				Debug.Log(_msg + " " + i + " > " + _t[i]);
		}
	}
}
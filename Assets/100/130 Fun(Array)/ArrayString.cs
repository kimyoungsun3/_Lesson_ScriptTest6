using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArrayTest
{
	public class ArrayString : MonoBehaviour
	{

		public string[] array = new string[2];
		void Start()
		{
			Display<string>("Start1", array);
			Fun1(array);
			Display<string>("Start2", array);
		}

		void Fun1(string[] _array)
		{
			Display<string>(" Fun11", _array);
			for (int i = 0; i < _array.Length; i++)
				_array[i] += 10;
			Display<string>(" Fun12", _array);
		}

		void Display<T>(string _msg, T[] _t)
		{
			for (int i = 0; i < _t.Length; i++)
				Debug.Log(_msg + " " + i + " > " + _t[i]);
		}
	}
}

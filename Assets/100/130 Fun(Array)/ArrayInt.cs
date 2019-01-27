using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArrayTest
{
	public class ArrayInt : MonoBehaviour
	{
		public int[] arrayInt = new int[2];
		void Start()
		{
			Display<int>("Start1", arrayInt);
			Fun1(arrayInt);
			Display<int>("Start2", arrayInt);
		}

		void Fun1(int[] _array)
		{
			Display<int>(" Fun11", _array);
			for (int i = 0; i < _array.Length; i++)
				_array[i] *= 10;
			Display<int>(" Fun12", _array);
		}

		void Display<T>(string _msg, T[] _t)
		{
			for (int i = 0; i < _t.Length; i++)
				Debug.Log(_msg + " " + i + " > " + _t[i]);
		}
	}
}

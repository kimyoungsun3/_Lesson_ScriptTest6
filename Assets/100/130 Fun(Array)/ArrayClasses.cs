using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArrayTest
{
	public class ArrayClasses : MonoBehaviour
	{
		public float[] array = new float[2];
		void Start()
		{
			Display<float>("Start1", array);
			Fun1(array);
			Display<float>("Start2", array);
		}

		void Fun1(float[] _array)
		{
			Display<float>(" Fun11", _array);
			for (int i = 0; i < _array.Length; i++)
				_array[i] *= 10;
			Display<float>(" Fun12", _array);
		}

		void Display<T>(string _msg, T[] _t)
		{
			for (int i = 0; i < _t.Length; i++)
				Debug.Log(_msg + " " + i + " > " + _t[i]);
		}
	}
}

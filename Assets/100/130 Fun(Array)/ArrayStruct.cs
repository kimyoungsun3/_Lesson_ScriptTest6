using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ArrayTest
{
	[System.Serializable]
	public struct TAG_Sample
	{
		public float x, y, z;
		
		public override string ToString()
		{
			return string.Format("({0}, {1}, {2})", x, y, z);
		}
	}

	public class ArrayStruct : MonoBehaviour
	{
		public TAG_Sample[] array = new TAG_Sample[2];
		void Start()
		{
			Display<TAG_Sample>("Start1", array);
			Fun1(array);
			Display<TAG_Sample>("Start2", array);
		}

		void Fun1(TAG_Sample[] _array)
		{
			Display<TAG_Sample>(" Fun11", _array);
			for (int i = 0; i < _array.Length; i++)
				_array[i].x *= 10;
			Display<TAG_Sample>(" Fun12", _array);
		}

		void Display<T>(string _msg, T[] _t)
		{
			for (int i = 0; i < _t.Length; i++)
				Debug.Log(_msg + " " + i + " > " + _t[i].ToString());
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MemoryLocation2
{
	public class AAA
	{
		public int x;
		public override string ToString()
		{
			return base.ToString() + " x:" + x;
		}
	}
	public class BBB
	{
		public static AAA[] CreateAAA(int _size)
		{
			AAA[] _array = new AAA[_size];
			return _array;
		}

		public static byte[] CreateByte(int _size)
		{
			byte[] _array = new byte[_size];
			return _array;
		}
	}

	public class Location2 : MonoBehaviour
	{
		public AAA[] array;
		public byte[] buffer;

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				array = BBB.CreateAAA(16);
			}
			else if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				buffer = BBB.CreateByte(16);
			}

			Debug.Log(array);
			Debug.Log(buffer);
		}
	}
}
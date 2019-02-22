using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MemoryLocation3
{
	public class AAA
	{
		public int x;
		public override string ToString()
		{
			return base.ToString() + " x:" + x;
		}
	}
	public class BBB<T>
	{
		public T[] CreateT(int _size)
		{
			T[] _array = new T[_size];
			return _array;
		}
	}

	public class Location3 : MonoBehaviour
	{
		public AAA[] array;
		public byte[] buffer;
		public BBB<AAA> b1	= new BBB<AAA>();
		public BBB<byte> b2 = new BBB<byte>();

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				array = b1.CreateT(16);
			}
			else if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				buffer = b2.CreateT(16);
			}

			Debug.Log(array);
			Debug.Log(buffer);
		}
	}
}
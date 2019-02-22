using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MemoryLocation1
{
	public class AAA
	{
		public int x;
		public override string ToString()
		{
			return base.ToString() + " x:" + x;
		}
	}

	public class Location1 : MonoBehaviour
	{
		public AAA[] array;
		public byte[] buffer;

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				array = new AAA[16];
			}
			else if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				buffer = new byte[16];
			}

			Debug.Log(array);
			Debug.Log(buffer);
		}
	}
}
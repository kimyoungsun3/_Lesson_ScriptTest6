using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace ArrayTest
{
	public class ArrayCopy : MonoBehaviour
	{
		public byte[] buffer = new byte[8];
		public byte[] buffer2 = new byte[8];
		
		// Use this for initialization
		void Start()
		{
			for (int i = 0; i < 4; i++)
			{
				buffer[i] = (byte)UnityEngine.Random.Range(0, 256);
			}

			Array.Copy(buffer, 0, buffer2, 2, 4);




		}
		
	}
}

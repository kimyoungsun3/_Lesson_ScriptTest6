using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace NetworkArray
{
	public class ArrayCopy : MonoBehaviour
	{
		public byte[] src	= new byte[8];
		public byte[] target = new byte[8];
		
		// Use this for initialization
		void Start()
		{
			for (int i = 0; i < 4; i++)
			{
				src[i] = (byte)UnityEngine.Random.Range(0, 256);
			}

			Array.Copy(src, 0, target, 2, 4);
		}		
	}
}

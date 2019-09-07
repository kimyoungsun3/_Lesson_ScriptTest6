using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace NetworkArray
{
	public class ArrayReadCompare : MonoBehaviour
	{
		public byte[] src = new byte[8];
		float[] t = new float[10];
		public int LOOP_MAX = 1000000;

		private void Start()
		{
			for (int i = 0; i < src.Length; i++)
				src[i] = (byte)(i + 1);
		}

		void Update()
		{
			t[0] = Time.realtimeSinceStartup;
			FunGetInt();
			t[1] = Time.realtimeSinceStartup;
			FunGetIntClass();
			t[2] = Time.realtimeSinceStartup;
			FunConverBitConverter();
			t[3] = Time.realtimeSinceStartup;
			FunConverBitConverter();
			t[4] = Time.realtimeSinceStartup;
			FunGetIntClass();
			t[5] = Time.realtimeSinceStartup;
			FunGetInt();
			t[6] = Time.realtimeSinceStartup;


			Debug.Log("=========================");
			Debug.Log("FunGetInt :"				+ (t[1] - t[0]));
			Debug.Log("FunGetIntClass :"		+ (t[2] - t[1]));
			Debug.Log("FunConverBitConverter :" + (t[3] - t[2]));
			Debug.Log("FunConverBitConverter :" + (t[4] - t[3]));
			Debug.Log("FunGetIntClass :"		+ (t[5] - t[4]));
			Debug.Log("FunGetInt :"				+ (t[6] - t[5]));
		}

		void FunGetInt()
		{
			int x = 0;
			for(int i = 0; i < LOOP_MAX; i++)
			{
				x = GetInt(src, 0);
			}
		}

		void FunGetIntClass()
		{
			int x = 0;
			for (int i = 0; i < LOOP_MAX; i++)
			{
				x = NUtil.GetInt(src, 0);
			}
		}

		int GetInt(byte[] _src, int _pos)
		{
			return (int)(
				   _src[_pos + 0]
				| (_src[_pos + 1] <<  8)
				| (_src[_pos + 2] << 16)
				| (_src[_pos + 3] << 24));
		}

		void FunConverBitConverter()
		{
			int x = 0;
			for (int i = 0; i < LOOP_MAX; i++)
			{
				x = BitConverter.ToInt32(src, 0);
			}
		}

	}
}
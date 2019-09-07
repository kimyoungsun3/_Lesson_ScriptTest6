using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace NetworkArray
{
	public class ArrayReadBitConverter : MonoBehaviour
	{
		public byte[] src	= new byte[8];

		private void Start()
		{
			for (int i = 0; i < src.Length; i++)
				src[i] = (byte)(i + 1);

			Debug.Log("1, 2, 3, 4 (리트엔디안)구간별 읽기.");
		}

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				string _msg = "[" + src[0] + "] > ";
				Debug.Log(_msg + src[0]);
			}
			else if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				string _msg = "BitConvert [" + src[0] + "][" + src[1] + "] > ";
				Debug.Log(_msg + BitConverter.ToInt16(src, 0));
			}
			else if (Input.GetKeyDown(KeyCode.Alpha3))
			{
				string _msg = "BitConvert [" + src[0] + "][" + src[1] + "][" + src[2] + "][" + src[3] + "] > ";
				Debug.Log(_msg + BitConverter.ToInt32(src, 0));
			}

		}

		byte GetByte(int _pos)
		{
			return (byte)src[_pos];
		}

		short GetShort(int _pos)
		{
			return (short)( 
				    src[_pos + 0]  
				| ( src[_pos + 1] << 8));
		}

		int GetInt(int _pos)
		{
			return (int)(
				   src[_pos + 0]
				| (src[_pos + 1] << 8)
				| (src[_pos + 2] << 16)
				| (src[_pos + 3] << 24));
		}
	}
}

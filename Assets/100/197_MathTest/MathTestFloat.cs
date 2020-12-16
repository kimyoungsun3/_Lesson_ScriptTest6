using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathTest
{
	public class MathTestFloat : MonoBehaviour
	{
		public eCalType type = eCalType.Mod;
		public float startNum = 0, endNum = 10, increate = 1;
		public float value = 3;

		public bool bCalculate;
		
		void Cal_Mod()
		{
			for (float i = startNum; i <= endNum; i+=increate)
			{
				Debug.Log(i + " >> " + i % value);
			}
		}

		void Cal_Ceil()
		{
			for (float i = startNum; i <= endNum; i += increate)
			{
				Debug.Log(i + " >> " + Mathf.Ceil(i));
			}
		}

		void Cal_Round()
		{
			for (float i = startNum; i <= endNum; i += increate)
			{
				Debug.Log(i + " >> " + Mathf.Round(i));
			}
		}

		void Cal_Floor()
		{
			for (float i = startNum; i <= endNum; i += increate)
			{
				Debug.Log(i + " >> " + Mathf.Floor(i));
			}
		}

		void Cal_Int()
		{
			for (float i = startNum; i <= endNum; i += increate)
			{
				Debug.Log(i + " >> " + (int)(i));
			}
		}

		private void OnDrawGizmos()
		{
			if (bCalculate)
			{
				bCalculate = !bCalculate;
				switch (type)
				{
					case eCalType.Mod:		Cal_Mod(); break;
					case eCalType.Ceil:		Cal_Ceil(); break;
					case eCalType.Round:	Cal_Round(); break;
					case eCalType.Floor:	Cal_Floor(); break;
					case eCalType.Int:		Cal_Int(); break;
						//case eCalType.Sign: Cal_Sign(); break;


				}
			}
		}
	}
}
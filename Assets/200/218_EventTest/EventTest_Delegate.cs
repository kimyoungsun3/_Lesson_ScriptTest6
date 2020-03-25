using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventTest2
{
	public class EventTest_Delegate : MonoBehaviour
	{
		public delegate void VOID_FUN_VOID();
		public VOID_FUN_VOID onXXX;

		void Start()
		{
			//추가하기...
			onXXX += Fun1;
			onXXX += Fun2;
			onXXX += Fun3;

			if (onXXX != null)
			{
				Debug.Log("====[1. first add3 ]=====");
				onXXX();
			}

		}

		void Fun1()	{ Debug.Log("Fun1"); }
		void Fun2() { Debug.Log("Fun2"); }
		void Fun3() { Debug.Log("Fun3"); }
	}
}

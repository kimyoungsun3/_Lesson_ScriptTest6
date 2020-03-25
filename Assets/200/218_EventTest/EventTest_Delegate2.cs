using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventTest2
{
	public class EventTest_Delegate2 : MonoBehaviour
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

			//기존에 더 추가하기...
			onXXX += Fun1;
			if (onXXX != null)
			{
				Debug.Log("====[2. add 1 ]=====");
				onXXX();
			}

			//있던 없던 빼기...
			onXXX -= Fun1;
			if (onXXX != null)
			{
				Debug.Log("====[3. remove 1 ]=====");
				onXXX();
			}
		}

		void Fun1()	{ Debug.Log("Fun1"); }
		void Fun2() { Debug.Log("Fun2"); }
		void Fun3() { Debug.Log("Fun3"); }
	}
}

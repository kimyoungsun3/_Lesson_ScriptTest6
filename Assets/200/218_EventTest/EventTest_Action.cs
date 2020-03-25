using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EventTest2
{
	public class EventTest_Action : MonoBehaviour
	{
		public System.Action onXXX;

		void Start()
		{
			onXXX += Fun1;
			onXXX += Fun2;
			onXXX += Fun3;

			if (onXXX != null)
			{
				onXXX();
			}
		}

		void Fun1()	{ Debug.Log("Fun1"); }
		void Fun2() { Debug.Log("Fun2"); }
		void Fun3() { Debug.Log("Fun3"); }
	}
}

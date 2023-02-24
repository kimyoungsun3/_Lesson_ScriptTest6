using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Step215
{
	public class DelegateTest : MonoBehaviour
	{

		public delegate void VOID_FUN_VOID();
		VOID_FUN_VOID callback;
		Action callback2;

		void Start()
		{
			callback += Fun1;
			callback += Fun1;
			callback += Fun2;
			callback += Fun3;
			callback -= Fun1;

			//-----------------------
			if (callback != null)
			{
				callback();
			}

			callback2 += Fun1;
			callback2 += Fun2;
			callback2 += Fun3;
			if (callback2 != null)
			{
				callback2();
			}
		}

		void Fun1()	{ Debug.Log("Fun1");}
		void Fun2() { Debug.Log("Fun2"); }
		void Fun3() { Debug.Log("Fun3"); }


		void Update()
		{

		}
	}
}
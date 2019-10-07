using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace _215_DelegateFunc
{

	public class FuncAndFunc : MonoBehaviour
	{

		public static int damage;
		event Action<int> onFunc;
		void Start()
		{
			Debug.Log(" >> Action >> C,A,BBB");
			onFunc  = Clear;
			onFunc += FuncA;
			onFunc += FuncB;
			onFunc += FuncB;
			onFunc += FuncB;
			onFunc(3);
			Debug.Log(damage);
		}

		public void Clear(int _d)
		{
			Debug.Log("Clear");
			damage = 0;
		}

		public void FuncA(int num)
		{
			Debug.Log("FuncA");
			damage += num;
		}
		public void FuncB(int num)
		{
			Debug.Log("FuncB");
			damage += num;
		}

	}
}
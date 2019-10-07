using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

namespace _215_DelegateFunc
{
	public class FuncList : MonoBehaviour
	{
		Dictionary<int, Func<int, int>> dic = new Dictionary<int, Func<int, int>>();


		int FunX2(int _val)		{ return _val* 2;}
		int FunDiv(int _val)	{ return _val / 2;}
		int FunPlus(int _val)	{ return _val; }
		int FunMinus(int _val)	{ return -_val; }

		private void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				int _damage = 100;
				foreach(KeyValuePair<int, Func<int, int>> _pair in dic)
				{
					_damage += _pair.Value(5);
				}
				Debug.Log(_damage);
			}

			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				if(!dic.ContainsKey(1))
					dic.Add(1, FunX2);
			}
			else if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				if (!dic.ContainsKey(2))
					dic.Add(2, FunDiv);
			}
			else if (Input.GetKeyDown(KeyCode.Alpha3))
			{
				if (!dic.ContainsKey(3))
					dic.Add(3, FunPlus);
			}
			else if (Input.GetKeyDown(KeyCode.Alpha4))
			{
				if (!dic.ContainsKey(4))
					dic.Add(4, FunMinus);
			}
		}
	}
}

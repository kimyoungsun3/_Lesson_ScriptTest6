using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace _215_DelegateFunc
{
	public class ListAndAction : MonoBehaviour
	{
		List<Func<int, int>> listAction = new List<Func<int, int>>();

		int FunX2(int _val) { return _val * 2; }
		int FunDiv(int _val) { return _val / 2; }
		int FunPlus(int _val) { return _val; }
		int FunMinus(int _val) { return -_val; }

		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				int _damage = 100;
				foreach(Func<int, int> _on in listAction)
				{
					_damage += _on(5);
				}
				Debug.Log(_damage);
			}


			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				if (!listAction.Contains(FunX2))
					listAction.Add(FunX2);
			}
			else if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				if (!listAction.Contains(FunDiv))
					listAction.Add(FunDiv);
			}
			else if (Input.GetKeyDown(KeyCode.Alpha3))
			{
				if (!listAction.Contains(FunPlus))
					listAction.Add(FunPlus);
			}
			else if (Input.GetKeyDown(KeyCode.Alpha4))
			{
				if (!listAction.Contains(FunMinus))
					listAction.Add(FunMinus);
			}
		}
	}
}

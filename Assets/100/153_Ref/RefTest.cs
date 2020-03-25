using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _153_RefTest
{
	public class RefTest : MonoBehaviour
	{
		// Use this for initialization
		void Start()
		{
			float _x = 0f;
			Vector3 _pos = Vector3.one;
			Display("step1", _x, _pos);
			ChangeValue(ref _x);
			ChangeValue(ref _pos);
			Display("step2", _x, _pos);

		}

		void ChangeValue(ref float _x)
		{
			_x += 2;
		}

		void ChangeValue(ref Vector3 _pos)
		{
			_pos *= 2;
		}

		void Display(string _msg, float _x, Vector3 _pos)
		{
			Debug.Log(_msg + " _x:" + _x + " _pos:" + _pos); 
		}
	}
}

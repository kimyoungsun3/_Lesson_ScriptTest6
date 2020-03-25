using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EventTest2
{
	public class EventTest_ActionParam : MonoBehaviour
	{
		public System.Action<Vector3, Vector3> onXXX;

		void Start()
		{
			onXXX += Fun1;
			onXXX += Fun2;
			onXXX += Fun3;

			if (onXXX != null)
			{
				onXXX(Vector3.zero, Vector3.one);
			}
		}

		void Fun1(Vector3 _pos, Vector3 _pos2)	{ Debug.Log("Fun1 " + _pos + ":" + _pos2); }
		void Fun2(Vector3 _pos, Vector3 _pos2) { Debug.Log("Fun2 " + _pos + ":" + _pos2); }
		void Fun3(Vector3 _pos, Vector3 _pos2) { Debug.Log("Fun3 " + _pos + ":" + _pos2); }
	}
}

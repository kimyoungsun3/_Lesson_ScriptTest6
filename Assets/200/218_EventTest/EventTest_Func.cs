using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EventTest2
{
	public class EventTest_Func : MonoBehaviour
	{
		public System.Func<Vector3> onXXX;

		void Start()
		{
			onXXX += Fun1;
			onXXX += Fun2;
			onXXX += Fun3;

			if (onXXX != null)
			{
				Vector3 _rtn = onXXX();
				Debug.Log(_rtn);
			}
		}

		Vector3 Fun1()	{	Debug.Log("Fun1"); return Vector3.one*1f; }
		Vector3 Fun2() {	Debug.Log("Fun2"); return Vector3.one*2f; }
		Vector3 Fun3() {	Debug.Log("Fun3"); return Vector3.one*3f; }
	}
}

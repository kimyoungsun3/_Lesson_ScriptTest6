using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



namespace UnityEventTest
{
	public class EventTest_UnityEvent : MonoBehaviour
	{
		public UnityEvent onXXX;
		public UnityEvent<Vector3> onXXX2;
		public UnityEvent<Vector3, Vector3> onXXX3;

		private void Start()
		{
			//이벤트 추가하기...
			onXXX.AddListener(Fun1_Sub);
		}

		private void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				if(onXXX != null)
				{
					onXXX.Invoke();
				}
			}
		}

		void Fun1_Sub()
		{
			Debug.Log("Fun1_Sub");
		}

		public void Invoke_Fun1()					{ Debug.Log("Fun1"); }
		public void Invoke_Fun2(Vector3 _pos)		{ Debug.Log("Fun2 >> " + _pos); }
		public Vector3 Invoke_Fun3(Vector3 _pos)	{ Debug.Log("Fun3 >> " + _pos); return _pos; }
	}
}

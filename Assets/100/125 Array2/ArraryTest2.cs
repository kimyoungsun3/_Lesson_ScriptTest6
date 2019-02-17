using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Array2Test2
{
	[System.Serializable]
	public class AAA
	{
		public int x1;
		public int x2;
	}


	public class ArraryTest2 : MonoBehaviour
	{
		public AAA[] array = new AAA[0];
		public AAA aaa;

		void Start()
		{
			array = new AAA[4];
			//Debug.Log(array[0].x1); //error
			Debug.Log("Start:" + array[0] + ":" + array.Length);
			Debug.Log("Start:" + aaa);
			Debug.Log("Start:" + (array[0] == null));
		}

		//Error
		//void OnEnable()		{ Debug.Log("OnEnable:" + array[0] + ":" + array.Length); }
		//void OnDisable()	{ Debug.Log("OnDisable:" + array[0] + ":" + array.Length); }
		void FixedUpdate()	{
			Debug.Log("FixedUpdate:" + array[0] + ":" + array.Length);
			Debug.Log("FixedUpdate:" + (array[0] == null));
		}
		void Update()		{
			Debug.Log("Update:" + array[0] + ":" + array.Length);
			Debug.Log("Update:" + (array[0] == null));

			if (Input.GetMouseButtonDown(0))
			{
				AAA[] _arr2 = new AAA[4];
				Debug.Log(" > _arr2.Length:" + _arr2.Length); 
				Debug.Log(" > _arr2[0]:" + _arr2[0]);
				Debug.Log(" > _arr2[0].x1:" + _arr2[0].x1);
			}
			else if (Input.GetMouseButtonDown(1))
			{
				AAA _a = new AAA();
				Debug.Log(" > _a:" + _a);
				Debug.Log(" > _a.x1:" + _a.x1);

			}
		}
	}
}

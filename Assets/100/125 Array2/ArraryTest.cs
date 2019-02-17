using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Array2Test
{
	[System.Serializable]
	public class AAA
	{
		public int x1;
		public int x2;
	}


	public class ArraryTest : MonoBehaviour
	{
		public AAA[] array; 

		void Start()
		{
			array = new AAA[4];
			Debug.Log("Start:" + array[0] + ":" + array.Length);
		}

		//Error
		void OnEnable()		{ Debug.Log("OnEnable:" + array[0] + ":" + array.Length); }
		void OnDisable()	{ Debug.Log("OnDisable:" + array[0] + ":" + array.Length); }
		void FixedUpdate()	{ Debug.Log("FixedUpdate:" + array[0] + ":" + array.Length); }
		void Update()		{ Debug.Log("Update:" + array[0] + ":" + array.Length); }
	}
}

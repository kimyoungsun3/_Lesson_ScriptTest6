using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorTest21
{
	[System.Serializable]
	public class AAA
	{
		public float x = -999f;
	}

	public class InspectorTest1 : MonoBehaviour
	{
		public Transform[] arrayTrans;
		public AAA[] arrayAAA;
		void Start()
		{
			arrayTrans	= new Transform[2];
			arrayAAA	= new AAA[2];

			Debug.Log("Start arrayTrans[0]:" + arrayTrans[0]);
			Debug.Log("Start arrayAAA[0]:"	+ arrayAAA[0]);
		}

		private void Update()
		{
			Debug.Log("Update arrayTrans[0]:"	+ arrayTrans[0]);
			Debug.Log("Update arrayAAA[0]:"		+ arrayAAA[0]);
		}
	}
}
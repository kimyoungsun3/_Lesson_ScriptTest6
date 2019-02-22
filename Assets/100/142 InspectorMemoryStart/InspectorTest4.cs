using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorTest24
{
	[System.Serializable]
	public class AAA
	{
		public float x = -999f;
	}

	public class InspectorTest4 : MonoBehaviour
	{
		Transform[] arrayTrans;
		AAA[] arrayAAA;
		void Start()
		{
			Debug.Log("Start arrayTrans:" + arrayTrans);
			Debug.Log("Start arrayAAA:" + arrayAAA);
		}

		private void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				arrayTrans = new Transform[2];
				arrayAAA = new AAA[2];
			}
			Debug.Log("Update arrayTrans[0]:" + arrayTrans[0]);
			Debug.Log("Update arrayAAA[0]:" + arrayAAA[0]);
		}
	}
}
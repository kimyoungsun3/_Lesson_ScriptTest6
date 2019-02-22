using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorTest1
{
	[System.Serializable]
	public class AAA
	{
		public float x, y, z;
	}

	public class InspectorTest1 : MonoBehaviour
	{
		public Transform[] arrayTrans;
		public List<Transform> listTrans;
		public AAA[] arrayAAA;
		public List<AAA> listAAA;
		void Start()
		{
			if (arrayTrans != null) Debug.Log("Transform[] arrayTrans:" + arrayTrans.Length);
			if (listTrans != null)	Debug.Log("List<Transform> listTrans:" + listTrans.Count);
			if (arrayAAA != null)	Debug.Log("AAA[] arrayAAA:" + arrayAAA.Length);
			if (listAAA != null)	Debug.Log("List<AAA> listAAA:" + listAAA.Count);
		}

		private void Update()
		{
			if (arrayTrans != null && arrayTrans.Length > 0)Debug.Log("arrayTrans[0]:" + arrayTrans[0]);
			if (listTrans != null && listTrans.Count > 0)	Debug.Log("listTrans[0]:" + listTrans[0]);
			if (arrayAAA != null && arrayAAA.Length > 0)	Debug.Log("arrayAAA[0].x:" + arrayAAA[0].x);
			if (listAAA != null && listAAA.Count > 0)		Debug.Log("listAAA[0]:" + listAAA[0].x);
		}
	}
}
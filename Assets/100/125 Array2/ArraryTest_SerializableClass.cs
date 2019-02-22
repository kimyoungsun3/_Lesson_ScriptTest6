using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Array2Test1
{
	[System.Serializable]
	public class Item
	{
		public int x1;
	}

	public class ArraryTest_SerializableClass : MonoBehaviour
	{
		public Item[] array;
		void Start()
		{
			array = new Item[4];
			Debug.Log(this + " Start:" + array[0] + ":" + array.Length);
		}

		void Update()
		{
			Debug.Log(this + " Update:" + array[0] + ":" + array.Length);
		}
	}
}

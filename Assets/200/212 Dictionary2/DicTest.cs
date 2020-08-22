using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _212_Dictionary
{
	public class DicTest : MonoBehaviour
	{
		public Dictionary<int, int> dic = new Dictionary<int, int>();
		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				int _key = Random.Range(0, 10);
				int _value = _key * 100;
				Debug.Log("add:" + _key);
				if (!dic.ContainsKey(_key))
				{
					dic.Add(_key, _value);
				}
			}

			if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				int i = 0;
				foreach (int _tKey in dic.Keys)
				{
					Debug.Log("key["+i+"]" + " >> " + _tKey);
					i++;
				}
			}

			if (Input.GetKeyDown(KeyCode.Alpha3))
			{
				int i = 0;
				foreach (int _tValue in dic.Values)
				{
					Debug.Log("key[" + i + "]" + " >> " + _tValue);
					i++;
				}
			}

		}
	}
}
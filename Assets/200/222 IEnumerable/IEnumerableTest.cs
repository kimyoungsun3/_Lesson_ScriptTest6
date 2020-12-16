using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace IEnumerableTest
{
	public class IEnumerableTest : MonoBehaviour
	{
		[SerializeField] string[] strList = {"One", "Two", "Three", "Four"};

		void Start()
		{
			IEnumerator _e = strList.GetEnumerator();
			while (_e.MoveNext())
			{
				Debug.Log("Start:" + _e.Current);
			}		
		}

		// Update is called once per frame
		void Update()
		{
			Debug.Log("Update");
		}
	}
}

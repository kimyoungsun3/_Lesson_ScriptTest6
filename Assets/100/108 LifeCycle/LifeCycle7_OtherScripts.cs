using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LifeCycleTest
{
	public class LifeCycle7_OtherScripts : MonoBehaviour
	{

		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				if (LifeCycle7_Singleton.ins != null)
					LifeCycle7_Singleton.ins.SetData(100f);
			}
		}
	}
}

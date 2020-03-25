using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LifeCycleTest
{
	public class LifeCycle3 : MonoBehaviour
	{
		//-----------------------
		void Awake()
		{
			Debug.Log(this + " Awake");
			StartCoroutine(Co_Awake());
		}

		void OnEnable()
		{
			Debug.Log(this + " OnEnable");
			StartCoroutine(Co_OnEnable());
		}

		//-----------------------
		void Start()
		{
			Debug.Log(this + " Start");
			StartCoroutine(Co_Start());
		}

		//------------------------
		void FixedUpdate()
		{
			Debug.Log(this + " FixedUpdate");
		}
		void Update()
		{
			Debug.Log(this + " Update");
		}
		void LateUpdate()
		{
			Debug.Log(this + " LateUpdate");
		}

		IEnumerator Co_Awake()
		{
			while (true)
			{
				Debug.Log(this + " Co_Awake");
				yield return null;
			}
		}

		IEnumerator Co_Start()
		{
			while (true)
			{
				Debug.Log(this + " Co_Start");
				yield return null;
			}
		}

		IEnumerator Co_OnEnable()
		{
			while (true)
			{
				Debug.Log(this + " Co_OnEnable");
				yield return null;
			}
		}

		//------------------------
		void OnDisable()
		{
			Debug.Log(this + " OnDisable");
		}
	}
}

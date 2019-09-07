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
		}
		void OnEnable()
		{
			Debug.Log(this + " OnEnable");
		}

		//-----------------------
		void Start()
		{
			Debug.Log(this + " Start");
			StartCoroutine(Co_XXX());
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

		IEnumerator Co_XXX()
		{
			while (true)
			{
				Debug.Log(this + " Co_XXX");
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LifeCycleTest
{
	public class LifeCycle5_Co : MonoBehaviour
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

		int count = 0;
		float time;
		void Update()
		{
			Debug.Log(this + " Update");
			transform.Rotate(Vector3.up * 30f * Time.deltaTime);
			transform.Translate(Vector3.forward * .5f * Time.deltaTime);

			//if (Time.time > time)
			//{
			//	time = Time.time + 2f;
			//	count = (count + 1) % 3;
			//	if (count == 0) GetComponent<Renderer>().material.color = Color.red;
			//	else if (count == 1) GetComponent<Renderer>().material.color = Color.green;
			//	else if (count == 2) GetComponent<Renderer>().material.color = Color.blue;
			//}
		}
		void LateUpdate()
		{
			Debug.Log(this + " LateUpdate");
		}

		Material material;
		IEnumerator Co_Awake()
		{
			int _count = 0;
			material = GetComponent<Renderer>().material;
			while (true)
			{
				Debug.Log(this + " Co_Awake");

				//yield return null;
				yield return new WaitForSeconds(2f);
				if (_count == 0) material.color = Color.red;
				else if (_count == 1) material.color = Color.green;
				else if (_count == 2) material.color = Color.blue;
				_count++;
				_count = _count % 3;
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

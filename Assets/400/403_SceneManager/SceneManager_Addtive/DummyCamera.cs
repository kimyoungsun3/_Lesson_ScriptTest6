using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SceneManagerTest
{
	public class DummyCamera : MonoBehaviour
	{

		// Use this for initialization
		void Awake()
		{
			DestroyImmediate(gameObject);
		}
	}
}

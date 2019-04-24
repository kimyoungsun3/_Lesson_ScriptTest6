using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SceneTest2_LoadLevelAddtive
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
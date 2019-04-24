using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SceneTest3_LoadLevelAddtive
{
	public class DummyScript3 : MonoBehaviour
	{

		public AudioClip[] audioClips;
		public bool bDebug = false;

		private void Awake()
		{
			if (bDebug) Debug.Log(this + " Awake");
		}

		private void Start()
		{
			if (bDebug) Debug.Log(this + " Start");
		}

		private void Update()
		{
			if (bDebug) Debug.Log(this + " Update");
		}
	}
}
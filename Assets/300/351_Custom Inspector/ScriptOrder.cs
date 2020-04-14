using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _300_CustomInspector
{
	public class ScriptOrder : MonoBehaviour
	{
		public int attachNum;
		private void Awake()
		{
			Debug.Log(this + " Awake:" + attachNum);
		}
		// Use this for initialization
		void Start()
		{
			Debug.Log(this + " Start:" + attachNum);
		}

		// Update is called once per frame
		void Update()
		{
			Debug.Log(this + " Update:" + attachNum);
		}
	}

}
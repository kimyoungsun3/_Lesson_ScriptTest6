using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjectTest
{
	public class TestScriptableObjectCompare : MonoBehaviour
	{
		public ScriptData saveData_A1, saveData_A2;
		public ScriptData saveData_B;
		public AudioClip c1, c2;


		// Use this for initialization
		void Start()
		{
			Debug.Log("SaveData:" + (saveData_A1 == saveData_A2));
			Debug.Log("SaveData:" + (saveData_A1 == saveData_B));
			Debug.Log("Sound:" + (c1 == c2));



			AAA a1 = new AAA();
			AAA a2 = a1;
			AAA b1 = new AAA();
		}
	}

	public struct AAA
	{
		public int idx;
		private int idx2;
		public void Double()
		{
			idx *= 2;
		}
	}
}

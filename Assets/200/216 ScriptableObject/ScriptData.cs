using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjectTest
{
	[CreateAssetMenu(fileName ="SaveData", menuName ="ScriptDataTest/Data")]
	public class ScriptData : ScriptableObject
	{
		public int idx = 0;
		public void Double()
		{
			idx *= 2;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjectTest
{
	[CreateAssetMenu(fileName ="SaveData", menuName ="ScriptDataTest/UserData")]
	public class ScriptUserData : ScriptableObject
	{
		public float health;
		public float damage;
	}
}

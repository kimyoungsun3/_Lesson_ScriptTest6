using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _300_CustomInspector
{
	public class LevelScript : MonoBehaviour
	{


		[Range(0, 255)] public int baseAtt;
		[Range(0, 255)] public int weaponAtt;
		[Range(0, 255)] public int powerAtt;
		public int att
		{
			get { return baseAtt + Mathf.FloorToInt(baseAtt * (weaponAtt + powerAtt - 8) / 16); }
		}

		[Space(10)]
		public int experience;
		public int level
		{
			get { return experience / 750; }
		}
	}
}
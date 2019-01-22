using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTest5
{
	public enum ENUM_EQUIPMENT_PART { Hair, Chest, Legs, Toes, Arms };
	public class EnumTest5 : MonoBehaviour
	{
		public string[] partNames;
		public ENUM_EQUIPMENT_PART[] partArray;

		void Start(){
			partNames = System.Enum.GetNames(typeof(ENUM_EQUIPMENT_PART));
			partArray = new ENUM_EQUIPMENT_PART[partNames.Length];
		}
	}
}

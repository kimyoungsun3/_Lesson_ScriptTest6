using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTest4
{
	public enum ENUM_EQUIPMENT_PART { Hair, Chest, Legs, Toes, Arms };
	public class EnumTest4 : MonoBehaviour {
		public List<ENUM_EQUIPMENT_PART> parts1 = new List<ENUM_EQUIPMENT_PART>();
		public ENUM_EQUIPMENT_PART[] parts2 = new ENUM_EQUIPMENT_PART[0];
		
		void Start(){
			foreach (ENUM_EQUIPMENT_PART _part in parts1) {
				Debug.Log ("part1 -> " + _part); 
			}

			foreach (ENUM_EQUIPMENT_PART _part in parts2) {
				Debug.Log ("part2 -> " + _part); 
			}
		}
	}
}

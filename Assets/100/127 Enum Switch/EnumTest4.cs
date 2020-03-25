using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTest4
{
	public enum eEquipmentPart { Hair, Chest, Legs, Toes, Arms };
	public class EnumTest4 : MonoBehaviour {
		public List<eEquipmentPart> parts1 = new List<eEquipmentPart>();
		public eEquipmentPart[] parts2 = new eEquipmentPart[0];
		
		void Start(){
			foreach (eEquipmentPart _part in parts1) {
				Debug.Log ("part1 -> " + _part); 
			}

			foreach (eEquipmentPart _part in parts2) {
				Debug.Log ("part2 -> " + _part); 
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTest5
{
	public enum eEquipmentPart { Hair, Chest, Legs, Toes, Arms };
	public class EnumTest5 : MonoBehaviour
	{
		public string[] partNames;
		public eEquipmentPart[] partArray;

		void Start(){
			//partNames = System.Enum.GetNames(typeof(eEquipmentPart));
			//partArray = new eEquipmentPart[partNames.Length];
			partNames = System.Enum.GetNames(typeof(eEquipmentPart));
			partArray = new eEquipmentPart[partNames.Length];

		}
	}
}

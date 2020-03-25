using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTest
{
	public enum eEquipmentPart {
		Hair, Chest, Legs, Toes, Arms
	};

	public class EnumTest2 : MonoBehaviour {
		//[SerializeField]
		public eEquipmentPart[] parts = new eEquipmentPart[0];

		// Use this for initialization
		//void Start () {
		//	//int _len = System.Enum.GetNames(typeof(ENUM_EQUIPMENT_PART)).Length;
		//	//parts = new ENUM_EQUIPMENT_PART[_len];
		//}

	}
}

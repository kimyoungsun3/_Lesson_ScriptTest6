using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTest
{
	[System.Serializable]
	public class EquipmentData {
		public eEquipmentPart part;
		public Sprite icon;
		public SkinnedMeshRenderer skin;
	}
	
	public class EnumTest2_3 : MonoBehaviour {
		//[SerializeField]
		public List<EquipmentData> parts = new List<EquipmentData>();

		// Use this for initialization
		//void Start () {
		//	//int _len = System.Enum.GetNames(typeof(ENUM_EQUIPMENT_PART)).Length;
		//	//parts = new ENUM_EQUIPMENT_PART[_len];
		//}

	}
}

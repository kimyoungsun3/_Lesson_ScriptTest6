using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTest2Block{
	public enum ENUM_EQUIPMENT_PART { Hair, Chest, Legs, Toes, Arms };
	public class EnumTest2 : MonoBehaviour {
		[SerializeField]
		private ENUM_EQUIPMENT_PART[] parts;

		// Use this for initialization
		void Start () {
			int _len = System.Enum.GetNames(typeof(ENUM_EQUIPMENT_PART)).Length;
			parts = new ENUM_EQUIPMENT_PART[_len];
		}

	}
}

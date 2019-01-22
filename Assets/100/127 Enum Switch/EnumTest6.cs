using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTest6
{
	public enum ENUM_EQUIPMENT_PART { Hair, Chest, Legs, Toes, Arms };
	public class EnumTest6 : MonoBehaviour
	{
		
		void Start(){

			ENUM_EQUIPMENT_PART part = ENUM_EQUIPMENT_PART.Hair;
			Debug.Log((int)part + " <- " + part);

			int partInt = 0;
			Debug.Log((ENUM_EQUIPMENT_PART)partInt + " <- " + partInt);
			partInt = 1;
			Debug.Log((ENUM_EQUIPMENT_PART)partInt + " <- " + partInt);
			partInt = 2;
			Debug.Log((ENUM_EQUIPMENT_PART)partInt + " <- " + partInt);
		}
	}
}

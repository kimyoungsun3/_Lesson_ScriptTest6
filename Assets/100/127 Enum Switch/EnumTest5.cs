using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTest5
{
	public enum eEquipmentPart { Hair, Chest, Legs, Toes, Arms };
	public class EnumTest5 : MonoBehaviour
	{
		public string[] listName;
		public eEquipmentPart[] listTypeFromString;
		public eEquipmentPart[] listTypeFromInt;
		public eEquipmentPart[] listTypeFromInt2;

		void Start(){
			//partNames = System.Enum.GetNames(typeof(eEquipmentPart));
			//partArray = new eEquipmentPart[partNames.Length];
			listName			= System.Enum.GetNames(typeof(eEquipmentPart));
			listTypeFromString	= new eEquipmentPart[listName.Length];
			listTypeFromInt		= new eEquipmentPart[listName.Length];
			listTypeFromInt2	= new eEquipmentPart[listName.Length];

			for (int i = 0; i < listTypeFromString.Length; i++)
			{
				listTypeFromString[i] = (eEquipmentPart)System.Enum.Parse( typeof(eEquipmentPart),  listName[i]);
			}
			for (int i = 0; i < listTypeFromString.Length; i++)
			{
				listTypeFromInt[i] = (eEquipmentPart)System.Enum.ToObject(typeof(eEquipmentPart), i);
			}
			for (int i = 0; i < listTypeFromString.Length; i++)
			{
				listTypeFromInt2[i] = (eEquipmentPart)i;
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EquipmentTest
{
	public enum ENUM_PART { Head, Body, Leg }

	[CreateAssetMenu(menuName = "Inventory/Item", fileName = "Item")]
	public class Item : ScriptableObject
	{
		new public string name;
		public Sprite sprite;
		public ENUM_PART part;
		public bool bDefault;
	}

}
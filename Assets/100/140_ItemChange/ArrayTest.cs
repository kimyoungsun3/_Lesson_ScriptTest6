using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EquipmentTest
{
	public class ArrayTest : MonoBehaviour
	{
		public List<Item> list_Items = new List<Item>();
		public Item[] list_DefaultItems = new Item[0];
		public Item[] currentEquipment;

		void Start()
		{
			int _len = System.Enum.GetNames(typeof(ENUM_PART)).Length;
			currentEquipment = new Item[_len];

			//EquipDefault();
		}
		void EquipDefault()
		{
			for (int i = 0, iMax = list_DefaultItems.Length; i < iMax; i++)
			{
				Equip(list_DefaultItems[i]);
			}
		}

		void Equip(Item _newItem)
		{
			int _partIdx = (int)_newItem.part;
			Item _oldItem = currentEquipment[_partIdx];
			//Debug.Log(_oldItem);
			if (_oldItem != null)
			{
				//Exist -> Expire and New Create
				Debug.Log(" Item is Exists and Expire and new Item");
			}

			//New Create
			currentEquipment[_partIdx] = _newItem;
		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Item _newItem = list_Items[Random.Range(0, list_Items.Count)];
				Equip(_newItem);

			}
		}
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTest
{
	public class EnumSwitch : MonoBehaviour
	{
		public enum eDirection
		{
			North, South, East, West
		};

		public eDirection dir = eDirection.North;

		void Start()
		{
			switch (dir)
			{
				case eDirection.North:
					Debug.Log(" North");
					break;
				case eDirection.South:
					Debug.Log(" South");
					break;
				case eDirection.East:
					Debug.Log(" East");
					break;
				case eDirection.West:
					Debug.Log(" West");
					break;
				default:
					Debug.Log(" xxx");
					break;
			}
		}
	}
}

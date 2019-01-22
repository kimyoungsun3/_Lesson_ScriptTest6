using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTest
{
	public class EnumSwitch : MonoBehaviour
	{
		public enum DIRECTION
		{
			North, South, East, West
		};

		public DIRECTION dir = DIRECTION.North;

		void Start()
		{
			switch (dir)
			{
				case DIRECTION.North:
					Debug.Log(" North");
					break;
				case DIRECTION.South:
					Debug.Log(" South");
					break;
				case DIRECTION.East:
					Debug.Log(" East");
					break;
				case DIRECTION.West:
					Debug.Log(" West");
					break;
				default:
					Debug.Log(" xxx");
					break;
			}
		}
	}
}

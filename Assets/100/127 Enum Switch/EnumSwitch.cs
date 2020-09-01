using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTest
{
	public class EnumSwitch : MonoBehaviour
	{
		public enum eDirection	{	North, South, East, West };

		public eDirection dir = eDirection.North;

		void Update()
		{
			Debug.Log(dir.ToString() + ":" + (int)dir);
			switch (dir)
			{
				case eDirection.North:
					break;
				case eDirection.South:
					break;
				case eDirection.East:
					break;
				case eDirection.West:
					break;
			}
		}
	}
}

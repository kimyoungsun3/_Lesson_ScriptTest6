using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumSwitch : MonoBehaviour {
	public enum Direction { 
		North, South, East, West
	};

	public Direction dir = Direction.North;

	void Start () {
		switch (dir) {
		case Direction.North:
			Debug.Log (" North");
			break;
		case Direction.South:
			Debug.Log (" South");
			break;
		case Direction.East:
			Debug.Log (" East");
			break;
		case Direction.West:
			Debug.Log (" West");
			break;
		default:
			Debug.Log (" xxx");
			break;
		}
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArraryTest{
	public class Player : MonoBehaviour {
		public static Player ins { get; private set; }
		[HideInInspector] public GameObject go;

		void Awake(){
			ins = this;
			go = gameObject;
		}
	}
}

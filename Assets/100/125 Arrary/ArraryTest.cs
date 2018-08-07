using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArraryTest{
	public class ArraryTest : MonoBehaviour {
		GameObject[] players;

		// Use this for initialization
		void Start () {
			players = GameObject.FindGameObjectsWithTag ("Player");

			for (int i = 0; i < players.Length; i++) {
				Debug.Log (i + " => " + players [i].name);
			}
		}
	}
}

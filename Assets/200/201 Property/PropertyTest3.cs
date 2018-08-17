using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PropertyTest{
	public class PropertyTest3 : MonoBehaviour {
		
		void Start () {
			UserData.ins.exp = 100;
			Debug.Log ("lv " + UserData.ins.level + " -> " + UserData.ins.job);


			UserData.ins.exp = 10000;
			Debug.Log ("lv " + UserData.ins.level + " -> " + UserData.ins.job);

			UserData.ins.exp = 30000;
			Debug.Log ("lv " + UserData.ins.level + " -> " + UserData.ins.job);
		}
	}
}
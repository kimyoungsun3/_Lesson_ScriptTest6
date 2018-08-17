using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PropertyTest{
	public class PropertyTest2 : MonoBehaviour {


		void Start(){
			UserData.ins.exp = 100;
			Debug.Log (UserData.ins.exp  + " > lv:" + UserData.ins.level);
		}
	}
}
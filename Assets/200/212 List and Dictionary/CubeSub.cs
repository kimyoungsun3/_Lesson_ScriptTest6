using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListAndDictionary{
	public class CubeSub : MonoBehaviour {

		void OnMouseDown(){
			Debug.Log (gameObject.name);
			CubeMaster.ins.AddTransform (transform);
		}
	}
}

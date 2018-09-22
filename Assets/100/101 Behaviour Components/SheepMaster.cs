using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComponentTest{
	public class SheepMaster : MonoBehaviour {
		public Transform trans;		//자기자신의 Transform.
		public GameObject go;		//자기자신의 GameObject.
		public Sheep2 scpSheep2;	//자기자신에 달려있는 Sheep2찾아 연결.
		public Sheep3 scpSheep3;	//다른 오브젝트에 있는것 찾아 연결하기.

		void Start(){
			Debug.Log ("Cube의 값들을 연결하세요(방법은 가리지말고)");
		}

	}
}

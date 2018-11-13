using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListAndDictionary{
	public class ClickAndRelease2 : MonoBehaviour {
		public Dictionary<Transform, Transform> dicList = new Dictionary<Transform, Transform>();

		void Update(){
			if (Input.GetMouseButtonDown (0)) {
				Ray _ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit _hit;
				if(Physics.Raycast(_ray, out _hit)){
					AddDic (_hit.collider.transform);
				}
			}
		}


		void AddDic(Transform _t){
			if (dicList.ContainsKey (_t)) {
				dicList.Remove (_t);
				_t.GetComponent<Renderer> ().material.color = Color.white;
			}else{
				dicList.Add (_t, _t);
				_t.GetComponent<Renderer> ().material.color = Color.red;
			}
		}
	}
}

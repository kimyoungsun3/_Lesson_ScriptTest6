using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListAndDictionary{
	public class ClickAndRelease : MonoBehaviour {
		public List<Transform> list = new List<Transform> ();

		void Update(){
			if (Input.GetMouseButtonDown (0)) {
				Ray _ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit _hit;
				if(Physics.Raycast(_ray, out _hit)){
					AddList (_hit.collider.transform);
				}
			}
		}


		void AddList(Transform _t){
			bool isFound = false;
			for (int i = 0; i < list.Count; i++) {
				if (_t == list [i]) {
					isFound = true;
					Debug.Log (" > Same Transform and Removing and Color change");
					list.Remove (_t);
					_t.GetComponent<Renderer> ().material.color = Color.white;
					break;
				}
			}

			if (isFound == false) {
				Debug.Log (" > New Find Add List and Change Color");
				list.Add (_t);
				_t.GetComponent<Renderer> ().material.color = Color.red;
			}
		}
	}
}

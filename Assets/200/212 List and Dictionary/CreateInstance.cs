using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListAndDictionary{
	public class CreateInstance : MonoBehaviour {
		public GameObject prefab;
		public List<GameObject> list = new List<GameObject> ();

		void Update () {
			if (Input.GetKeyDown (KeyCode.C)) {
				int _randValue = Random.Range (0, 10);
				string _name = prefab.name + _randValue;
				//Debug.Log (_randValue + _randValue + _randValue);
				//Debug.Log ("" + _randValue + _randValue + _randValue);
				//Debug.Log (_name + ":" + gameObject +":"+ _randValue);

				if( !list.Find(_go => _go.name == _name )){
					GameObject _go = Instantiate (
						prefab, 
						Random.onUnitSphere, 
						Quaternion.identity
					);

					_go.name = _name;
					list.Add (_go);
				}
			}
			
		}
	}
}
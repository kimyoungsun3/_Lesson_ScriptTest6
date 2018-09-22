using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Destroy{
	public class CreateOC : MonoBehaviour {
		public GameObject goPrefab;
		GameObject goTarget;

		void Start () {
			Debug.Log (" I Instanciate GameObject");
			Debug.Log (" C AddComponent<T>");
			Debug.Log (" G GetComponet<T>");
			
		}
		
		// Update is called once per frame
		void Update () {

			if (Input.GetKeyDown (KeyCode.I)) {
				goTarget = Instantiate (goPrefab, transform.position, Quaternion.identity);
				Debug.Log ("Create Prefab");
			} else if (Input.GetKeyDown (KeyCode.C)) {
				goTarget.AddComponent<DDDDD> ();
				Debug.Log ("AddComponet > Add Scripts");
			} else if (Input.GetKeyDown (KeyCode.G)) {
				DDDDD _scp = goTarget.GetComponent<DDDDD> ();
				_scp.SetData (100f, 1f);
				Debug.Log ("Create Prefab is Script Data that is changed");
			}
		}
	}
}
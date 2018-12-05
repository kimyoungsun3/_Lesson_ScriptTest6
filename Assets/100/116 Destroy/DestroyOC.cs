using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Destroy{
	public class DestroyOC : MonoBehaviour {

		// Use this for initialization
		void Start () {
			Debug.Log ("O destroy Object, C destroy collider, D 3 second destroy");
		}
		
		// Update is called once per frame
		void Update () {

			if (Input.GetKeyDown (KeyCode.O)) {
				Destroy (gameObject);
			} else if (Input.GetKeyDown (KeyCode.C)) {
				Destroy (GetComponent<Collider> ());
			} else if (Input.GetKeyDown (KeyCode.D)) {
				Destroy (gameObject, 3f);
				//Destroy (gameObject);
				DestroyImmediate(gameObject);
			}			
		}
	}
}

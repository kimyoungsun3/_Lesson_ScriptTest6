using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TranslateAndRotate{
	public class CubeMove2 : MonoBehaviour {
		
		// Update is called once per frame
		void Update () {
			transform.Translate (Vector3.forward * Time.deltaTime);
		}
	}
}
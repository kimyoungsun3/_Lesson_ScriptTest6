using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lerp{
	[ExecuteInEditMode]
	public class LerpTest2 : MonoBehaviour {
		public List<Transform> list = new List<Transform> ();
		[Range(0, 1)] public float interpolate;

		void OnDrawGizmos() {
			if (list.Count >= 2) {
				transform.position = Vector3.Lerp(list[0].position, list[1].position, interpolate);
			}			
		}
	}
}

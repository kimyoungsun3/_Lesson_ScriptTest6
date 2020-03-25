using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lerp{
	//[ExecuteInEditMode]
	public class LerpTest : MonoBehaviour {
		public float p1 = 0f;
		public float p2 = 100f;
		[Range(0, 1)] public float interpolate = .5f;

		private void OnDrawGizmos()
		{
			float _value = Mathf.Lerp(p1, p2, interpolate);

			Debug.Log (p1 + " ~ " + _value +"("+interpolate+")  ~ " + p2);
		}
	}
}

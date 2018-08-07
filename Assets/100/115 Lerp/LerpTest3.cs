using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lerp{
	public class LerpTest3 : MonoBehaviour {
		[Range(0, 1)] public float interpolate;
		Light light;
		public bool bSimulate = false;
		public bool bClear = false;

		void Start(){
			light = GetComponent<Light> ();
		}

		void Update () {
			if (bClear) {
				Reset ();
			}

			if (!bSimulate) {
				return;
			}

			if (light != null) {
				light.intensity = Mathf.Lerp(light.intensity, 8f, interpolate);
			}			
		}

		void Reset(){
			if (light != null) {
				light.intensity = 1f;
			}
			bClear = false;
			bSimulate = false;
		}

	}
}

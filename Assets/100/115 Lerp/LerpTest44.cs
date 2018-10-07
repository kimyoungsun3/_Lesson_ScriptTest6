using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lerp{
	public class LerpTest44 : MonoBehaviour {
		public float lightTime;
		float speedLightTime;
		float interpolate;
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
				interpolate = speedLightTime * Time.deltaTime;
				light.intensity = Mathf.Lerp(light.intensity, 8f, interpolate);
			}			
		}

		void Reset(){
			if (light != null) {
				light.intensity = 1f;
			}

			speedLightTime = 1f / lightTime;
			bClear = false;
			bSimulate = false;
		}
	}
}

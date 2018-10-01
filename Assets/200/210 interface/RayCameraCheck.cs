using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceTest{
	public class RayCameraCheck : MonoBehaviour {
		
		// Update is called once per frame
		void Update () {
			if (Input.GetMouseButtonDown (0)) {
				Ray _ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit _hit;
				if (Physics.Raycast (_ray, out _hit)) {
					IKillable _scpKill = _hit.collider.GetComponent<IKillable> ();
					if (_scpKill != null) {
						_scpKill.Kill ();
					}


					IDamageable<float> _scpDamage = _hit.collider.GetComponent<IDamageable<float>> ();
					if (_scpDamage != null) {
						_scpDamage.Damage (10f);
					}

				}
			}			
		}
	}
}

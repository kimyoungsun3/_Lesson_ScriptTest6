using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerTouch : MonoBehaviour {
	public float distance;
	public LayerMask mask;
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetMouseButtonDown (0)) {
		if (Input.GetMouseButton (0)) {
			Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit _hit;

			if (Physics.Raycast (_ray, out _hit, distance, mask)) {
				Debug.Log (_hit.collider.gameObject.name);
				CharTTT _scp = _hit.collider.GetComponent<CharTTT> ();
				if (_scp != null) {
					_scp.TakeDamage (1f);
				}
				Debug.DrawRay (_ray.origin, _ray.direction * _hit.distance, Color.green);
			} else {

				Debug.DrawRay (_ray.origin, _ray.direction * distance, Color.blue);
			}
		}
	}
}

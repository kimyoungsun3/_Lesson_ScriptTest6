using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick2 : MonoBehaviour {
	public LayerMask mask;
	public float power = 500f;

	void Start(){
	}

	void Update(){
		if(Input.GetMouseButtonDown(0)){
			Ray _ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit _hit;

			if(Physics.Raycast(_ray, out _hit, 100, mask)){
				Rigidbody _rb = _hit.rigidbody;
				if(_rb != null){
					_rb.AddForceAtPosition(_ray.direction * power, _hit.point);
				}
			}

		}
	}
}

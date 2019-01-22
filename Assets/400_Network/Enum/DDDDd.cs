using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDDDd : MonoBehaviour {

	public LayerMask mask;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit _hit;
			if(Physics.Raycast(_ray, out _hit, 100, mask))
			{
				Debug.Log(_hit.collider.name);
			}
		}
	}
}

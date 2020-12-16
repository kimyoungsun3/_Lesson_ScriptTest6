using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _300_ShaderTest
{
	public class MouseCursor : MonoBehaviour
	{
		Camera camera;
		Plane gridPlane;
		Transform trans;

		// Use this for initialization
		void Start()
		{
			camera = Camera.main;
			trans = transform;
			gridPlane = new Plane(-camera.transform.forward, Vector3.zero);
		}

		// Update is called once per frame
		void Update()
		{
			Ray _ray = camera.ScreenPointToRay(Input.mousePosition);
			float _distance;
			if(gridPlane.Raycast(_ray, out _distance))
			{
				trans.position = _ray.GetPoint(_distance);
			}
		}
	}

}
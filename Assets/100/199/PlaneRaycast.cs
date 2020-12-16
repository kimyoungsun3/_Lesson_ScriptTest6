using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://github.com/Unity-Technologies/UnityCsReference/blob/master/Runtime/Export/Geometry/Plane.cs
namespace _199_PlaneTest
{
	public class PlaneRaycast : MonoBehaviour
	{
		public Plane ground;
		Camera camera;
		public Transform guide;

		void Start()
		{
			ground = new Plane(-Camera.main.transform.forward, Vector3.zero);
			camera = Camera.main;
		}

		// Update is called once per frame
		void Update()
		{
			Ray _ray = camera.ScreenPointToRay(Input.mousePosition);
			float _distance = 0;
			if (ground.Raycast(_ray, out _distance))
			{
				Vector3 _hitPoint = _ray.GetPoint(_distance);
				guide.position = _hitPoint;
			}
		}
	}
}

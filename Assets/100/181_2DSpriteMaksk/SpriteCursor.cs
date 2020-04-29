using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _181_SpriteMask
{
	public class SpriteCursor : MonoBehaviour
	{
		Plane ground;
		Camera camera;
		Transform trans;
		[SerializeField] float wheelSpeed = 100f;
		float wheel = 1f;
		

		// Use this for initialization
		void Start()
		{
			trans = transform;
			camera = Camera.main;
			ground = new Plane(-camera.transform.forward, transform.position);
		}

		// Update is called once per frame
		void Update()
		{
			Ray _ray = camera.ScreenPointToRay(Input.mousePosition);
			float _distance;
			if (ground.Raycast(_ray, out _distance))
			{	
				trans.position = _ray.GetPoint(_distance);
			}

			float _wheel = Input.GetAxis("Mouse ScrollWheel");
			if( _wheel != 0f)
			{
				wheel += _wheel * wheelSpeed * Time.deltaTime;
				wheel = Mathf.Clamp(wheel, 0.5f, 2f);
				trans.localScale = Vector3.one * wheel;
			}

		}
	}
}

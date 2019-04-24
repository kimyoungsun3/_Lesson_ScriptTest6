using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EquipmentTestNameSpace
{
	public class Player : MonoBehaviour
	{
		//PlayerController controller;
		EquipmentGun equipmentGun;
		Vector3 move;
		public float moveSpeed = 2f;
		Plane plane;
		Camera camera;
		Transform trans;
		public List<Gun> listGuns = new List<Gun>();

		// Use this for initialization
		void Start()
		{
			//controller = GetComponent<PlayerController>();
			equipmentGun = GetComponent<EquipmentGun>();

			trans = transform;
			plane = new Plane(Vector3.up, Vector3.zero);
			camera = Camera.main;
		}


		void Update()
		{
			//move
			move.Set(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
			transform.position += move.normalized * moveSpeed * Time.deltaTime;

			//ray
			Ray _ray = camera.ScreenPointToRay(Input.mousePosition);
			float _distance = 0;
			if(plane.Raycast(_ray, out _distance))
			{
				Vector3 _point = _ray.GetPoint(_distance);
				_point.y = trans.position.y;
				trans.LookAt(_point);
			}

			//shoot
			if (Input.GetMouseButton(0))
			{
				equipmentGun.Shoot();
			}

			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				equipmentGun.WearGun(listGuns[0]);
			}
			else if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				equipmentGun.WearGun(listGuns[1]);
			}
		}
	}
}
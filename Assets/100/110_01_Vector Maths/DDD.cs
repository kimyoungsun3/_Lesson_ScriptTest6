using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VectorTest
{
	
	public class DDD : MonoBehaviour
	{
		public float speed = 2f;

		private void Update()
		{
			//연산후~ 이동..
			Vector3 _dir = transform.right;
			float _distance = speed * Time.deltaTime;
			Ray _ray = new Ray(transform.position, _dir);
			RaycastHit _hit;
			Debug.DrawRay(_ray.origin, _ray.direction * _distance, Color.white);

			if (Physics.Raycast(_ray, out _hit, _distance))
			{
				Vector3 _reflect = Reflect(-_ray.direction, _hit.normal).normalized;
				_distance = (_distance - _hit.distance);
				Debug.DrawRay(_hit.point, _reflect.normalized * _distance, Color.green);
				Debug.Log(1);

				_ray = new Ray(_hit.point, _reflect.normalized);
				if(Physics.Raycast(_ray, out _hit, _distance))
				{
					_reflect = Reflect(-_ray.direction, _hit.normal).normalized;
					_distance = (_distance - _hit.distance);
					Debug.DrawRay(_hit.point, _reflect.normalized * _distance, Color.blue);
					Debug.Log(2);

					transform.position = _hit.point + _reflect * _distance;
					transform.rotation = Quaternion.FromToRotation(Vector3.right, _reflect);
				}
				else
				{
					Debug.Log(3);
					Debug.Log("_hit.point :" + _hit.point);
					Debug.Log("_reflect :" + _reflect);
					Debug.Log("_reflect :" + _reflect.magnitude);
					Debug.Log("_distance :" + _distance);
					Debug.Log("transform.position b :" + transform.position);
					transform.position = _hit.point + _reflect * _distance;
					transform.rotation = Quaternion.FromToRotation(Vector3.right, _reflect);
					Debug.Log("transform.position a :" + transform.position);
				}
			}
			else
			{
				transform.Translate(Vector3.right * speed * Time.deltaTime);
			}

		}


		Quaternion GetRotation2D(Vector3 _dir)
		{
			_dir = _dir.normalized;
			return Quaternion.Euler(0, 0, Mathf.Atan2(_dir.y, _dir.x) * Mathf.Rad2Deg);
		}

		//GetRotation3D(Vector3.right, _reflect);
		Quaternion GetRotation3D(Vector3 _axis, Vector3 _dir)
		{			
			return Quaternion.FromToRotation(_axis, _dir);
		}


		Vector3 Reflect(Vector3 _dir1, Vector3 _dir2)
		{
			Vector3 _project = Vector3.Dot(_dir1, _dir2) / Vector3.Dot(_dir2, _dir2) * _dir2;
			return -_dir1 + _project * 2;
		}


	}
}
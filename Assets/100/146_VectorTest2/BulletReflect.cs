using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VectorTest2
{
	public class BulletReflect : MonoBehaviour
	{
		Transform trans;
		[SerializeField] LayerMask layerMask;
		[SerializeField] float speed = 5f;
		Ray ray;
		RaycastHit hit;

		private void Start()
		{
			trans = transform;
		}

		//[SerializeField] bool isRun;
		void Update()
		{
			//if (isRun == false) return;

			ray.origin		= trans.position;
			ray.direction	= trans.right;
			float _distance = speed * Time.deltaTime;
			Vector3 _deltaPos= trans.right * _distance;
			//Debug.Log(ray.origin + ":" + _distance + ":" + Time.deltaTime);

			if (Physics.Raycast(ray, out hit, _distance, layerMask, QueryTriggerInteraction.Collide))
			{
				//Debug.Log(" >>");
				Vector3 _moveDir	= hit.point - ray.origin;
				float _moveDistance	= _moveDir.magnitude;
				Vector3 _reflect	= Vector3.Reflect(ray.direction, hit.normal).normalized;
				float _remainDistance	= _distance - _moveDistance;

				RaycastHit _hit2;
				if (Physics.Raycast(hit.point, _reflect, out _hit2, _remainDistance, layerMask, QueryTriggerInteraction.Collide))
				{
					Vector3 _moveDir2		= _hit2.point - hit.point;
					float _moveDistance2	= _moveDir2.magnitude;
					Vector3 _reflect2		= Vector3.Reflect(_reflect, _hit2.normal).normalized;
					float _remainDistance2 = _remainDistance - _moveDistance2;

					trans.position = _hit2.point + _remainDistance2 * _reflect2;
					trans.rotation = GetRotation2D(_reflect2);
				}
				else
				{
					trans.position = hit.point + _remainDistance * _reflect;
					trans.rotation = GetRotation2D(_reflect);
				}
			}
			else
			{
				trans.Translate(_deltaPos, Space.World);
			}
		}

		Quaternion GetRotation2D(Vector3 _dir)
		{
			_dir = _dir.normalized;
			return Quaternion.Euler(0, 0, Mathf.Atan2(_dir.y, _dir.x) * Mathf.Rad2Deg);
		}

		private void OnDrawGizmos()
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(transform.position, 1f/2f);
		}
	}
}

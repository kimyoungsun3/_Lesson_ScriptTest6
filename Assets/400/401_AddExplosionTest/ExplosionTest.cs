using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExplosionTestNameSpace
{
	public class ExplosionTest : MonoBehaviour
	{
		public float cusumePower = 1000f;
		public float explosionPower = 1000f;
		public float explosionRadius = 5f;
		public LayerMask mask;

		private void Start()
		{
			Debug.Log("1. 왼마우스 폭발, 오른 마우스 빨아폭발");
		}

		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				//Debug.Log(11);
				Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit _hit;
				if(Physics.Raycast(_ray, out _hit))
				{
					//Debug.Log(12);
					Vector3 _hitPoint = _hit.point;
					Rigidbody _rb;
					Collider[] _cols = Physics.OverlapSphere(_hitPoint, explosionRadius);
					for(int i = 0, iMax = _cols.Length; i < iMax; i++)
					{
						//Debug.Log(13);
						_rb = _cols[i].GetComponent<Rigidbody>();
						if(_rb != null)
						{
							_rb.AddExplosionForce(explosionPower, _hitPoint, explosionRadius);
						}
					}
				}
			}
			else if (Input.GetMouseButtonDown(1))
			{
				Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit _hit;
				if (Physics.Raycast(_ray, out _hit))
				{
					//Debug.Log(12);
					Vector3 _hitPoint = _hit.point;
					Vector3 _dir;
					float _distance, _powerPercent;
					Rigidbody _rb;
					Collider[] _cols = Physics.OverlapSphere(_hitPoint, explosionRadius);
					for (int i = 0, iMax = _cols.Length; i < iMax; i++)
					{
						//Debug.Log(13);
						_rb = _cols[i].GetComponent<Rigidbody>();
						if (_rb != null)
						{
							_dir = _hitPoint - _rb.position;
							_distance = _dir.magnitude;
							_powerPercent = (explosionRadius - _distance) / explosionRadius;
							if (_powerPercent < 0f) continue;
							_rb.AddForce(_dir * _powerPercent * explosionPower);
							//_rb.AddExplosionForce(explosionPower, _hitPoint, explosionRadius);
						}
					}
				}
			} 
		}
	}

}
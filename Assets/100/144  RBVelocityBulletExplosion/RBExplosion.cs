using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RBVelocityTest
{
	struct PositionData
	{
		public Rigidbody rb;
		public Vector3 pos;
		public Quaternion rot;

		public void Backup(Rigidbody _rb)
		{
			if (rb != null) return;

			rb = _rb;
			pos = rb.position;
			rot = rb.rotation;
			//rb.isKinematic = false;
		}

		public void RefPosition()
		{
			rb.isKinematic = true;
			rb.position = pos;
			rb.rotation = rot;
		}
	}

	public class RBExplosion : MonoBehaviour
	{
		public float explosionRadius;
		public float explosionForce;
		PositionData[] datas;

		// Update is called once per frame
		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Rigidbody _rb;
				Collider[] _cols = Physics.OverlapSphere(transform.position, explosionRadius);
				if (datas == null) datas = new PositionData[_cols.Length];

				for (int i = 0; i < _cols.Length; i++)
				{
					_rb = _cols[i].GetComponent<Rigidbody>();
					if(_rb != null)
					{
						datas[i].Backup(_rb);
						_rb.isKinematic = false;
						_rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);			
					}
				}
			}
			else if (Input.GetMouseButtonDown(1))
			{
				if(datas != null)
				{
					for(int i = 0; i < datas.Length; i++)
					{
						if(datas[i].rb != null)
						{
							datas[i].RefPosition();
						}
					}
				}
			}
		}

		private void OnDrawGizmos()
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(transform.position, explosionRadius);
		}
	}
}
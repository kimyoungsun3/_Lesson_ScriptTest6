using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _189_Rigidbody_2DAddFoce
{
	[System.Serializable]
	public struct TRS
	{
		public Rigidbody rigidbody;
		public Vector3 position;
		public Quaternion rotation;

		public TRS(Rigidbody _rb, Vector3 _p, Quaternion _r)
		{
			rigidbody	= _rb;
			position	= _p;
			rotation	= _r;
			rigidbody.isKinematic = true;
		}

		public void Reset()
		{
			rigidbody.isKinematic = true;
			rigidbody.position = position;
			rigidbody.rotation = rotation;
		}
	}

	public class Simulte3D : MonoBehaviour
	{
		public List<TRS> list = new List<TRS>();
		public float explosionForce = 100f;
		public float explosionRadius = 3f;
		public Transform hitPoint;

		// Use this for initialization
		void Start()
		{
			Rigidbody[] _rs = GetComponentsInChildren<Rigidbody>();
			Rigidbody _r;
			for (int i = 0, imax = _rs.Length; i < imax; i++)
			{
				_r = _rs[i];
				list.Add(new TRS(_r, _r.position, _r.rotation));

				//보이는 부분삭제...
				Renderer _render = _r.GetComponent<Renderer>();
				if (_render)
				{
					_render.enabled = false;
				}
			}
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.A))
			{
				for(int i = 0, imax = list.Count; i < imax; i++)
				{
					list[i].rigidbody.isKinematic = false;
					list[i].rigidbody.AddExplosionForce(explosionForce, hitPoint.position, explosionRadius);
				}
			}
			else if (Input.GetKeyDown(KeyCode.R))
			{
				for (int i = 0, imax = list.Count; i < imax; i++)
				{
					list[i].Reset();
				}
			}
		}

		private void OnDrawGizmos()
		{
			Gizmos.DrawWireSphere(hitPoint.position, explosionRadius);
		}
	}
}
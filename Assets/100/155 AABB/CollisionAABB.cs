using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CollisionTest
{
	public class CollisionAABB : MonoBehaviour
	{
		[SerializeField] Transform targetA, targetB;
		[SerializeField] bool bShow;
		[SerializeField] List<Transform> list = new List<Transform>();
		private void OnDrawGizmos()
		{
			if (targetA == null || targetB == null)
			{
				return;
			}

			Bounds _a = targetA.GetComponent<Collider>().bounds;
			Bounds _b = targetB.GetComponent<Collider>().bounds;


			//public bool Intersects(Bounds bounds)
			//{
			//	return (this.min.x > bounds.max.x || this.max.x < bounds.min.x 
			//			|| this.min.y > bounds.max.y || this.max.y < bounds.min.y 
			//			|| this.min.z > bounds.max.z ? false : this.max.z >= bounds.min.z);
			//}
			if (bShow)
			{
				//Debug.Log(_a.min + ":" + _a.max + ":" + _b.min + ":" + _b.max);
				list[0].position = _a.min;
				list[1].position = _a.max;
				list[2].position = _b.min;
				list[3].position = _b.max;
			}


			//if (_a.Intersects(_b))
			if (Intersects(_a, _b))
			{
				targetA.GetComponent<Renderer>().material.color = Color.red;
				targetB.GetComponent<Renderer>().material.color = Color.red;
			}
			else
			{
				targetA.GetComponent<Renderer>().material.color = Color.white;
				targetB.GetComponent<Renderer>().material.color = Color.white;
			}
		}

		public bool Intersects(Bounds _a, Bounds _b)
		{
			return (_a.min.x > _b.max.x || _a.max.x < _b.min.x 
				||	_a.min.y > _b.max.y || _a.max.y < _b.min.y 
				||	_a.min.z > _b.max.z 
				? false 
				: _a.max.z >= _b.min.z);
		}
	}
}

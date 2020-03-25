using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VectorTest2
{
	public class BulletSpawner : MonoBehaviour
	{
		[SerializeField] Vector2 min, max;
		[SerializeField] GameObject prefab;
		int num = 0;

		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Vector3 _pos = new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), 0);
				Quaternion _rot = Quaternion.Euler(0, 0, Random.Range(0, 360f));
				GameObject _go = Instantiate(prefab, _pos, _rot);
				_go.name += num++;
			}

		}

		private void OnDrawGizmos()
		{
			Gizmos.DrawLine(min - Vector2.right, min + Vector2.right);
			Gizmos.DrawLine(min - Vector2.up, min + Vector2.up);

			Gizmos.DrawLine(max - Vector2.right, max + Vector2.right);
			Gizmos.DrawLine(max - Vector2.up, max + Vector2.up);
		}
	}

}
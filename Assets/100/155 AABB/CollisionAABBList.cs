using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CollisionTest
{
	public class CollisionAABBList : MonoBehaviour
	{
		[SerializeField] GameObject prefab;
		[SerializeField] int count = 100;
		[SerializeField] List<Renderer> list = new List<Renderer>();

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				CreatePrefab();
			}
			else if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				float _t1 = Time.realtimeSinceStartup;
				CheckCollision();
				float _t2 = Time.realtimeSinceStartup;

				Debug.Log(list.Count + " >> " + (_t2 - _t1));
			}
		}

		void CreatePrefab()
		{
			Vector2 _pos2;
			Vector3 _pos = Vector3.zero;
			Quaternion _rot = Quaternion.identity;
			Renderer _render;
			for (int i = 0; i < count; i++)
			{
				_pos2 = Random.insideUnitCircle * 10;
				_pos.Set(_pos2.x, 0, _pos2.y);
				_render = Instantiate(prefab, _pos, _rot).GetComponent<Renderer>();
				list.Add(_render);
			}
		}

		void CheckCollision()
		{
			Renderer _a, _b;
			bool _bFirst;
			for (int i = 0, imax = list.Count; i < imax; i++)
			{
				_a = list[i];
				_bFirst = false;
				for (int j = i+1; j < imax; j++)
				{
					_b = list[j];
					if(Intersects(_a.bounds, _b.bounds))
					{
						if (_bFirst == false)
						{
							_a.material.color = Color.red;
						}
						_b.material.color = Color.red;
						_bFirst = true;
					}
				}
			}
		}

		bool Intersects(Bounds _a, Bounds _b)
		{
			return (_a.min.x > _b.max.x || _a.max.x < _b.min.x 
				||	_a.min.y > _b.max.y || _a.max.y < _b.min.y 
				||	_a.min.z > _b.max.z 
				? false 
				: _a.max.z >= _b.min.z);
		}
	}
}

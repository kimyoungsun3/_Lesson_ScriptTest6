using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CollisionTest
{
	[System.Serializable]
	public class BoundObject
	{
		public Bounds bounds;
		public Renderer renderer;
		public Material material;

		public BoundObject(Renderer _r, Material _m, Bounds _b)
		{
			renderer = _r;
			material = _m;
			bounds = _b;
		}
	}
	public class CollisionAABBListBounds : MonoBehaviour
	{

		[SerializeField] GameObject prefab;
		[SerializeField] int count = 100;
		[SerializeField] List<BoundObject> list = new List<BoundObject>();

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
			GameObject _go;
			Renderer _r;
			Material _m;
			for (int i = 0; i < count; i++)
			{
				_pos2 = Random.insideUnitCircle * 10;
				_pos.Set(_pos2.x, 0, _pos2.y);
				_go = Instantiate(prefab, _pos, _rot);
				_r = _go.GetComponent<Renderer>();
				_m = _r.material;
				list.Add(new BoundObject(_r, _m, _r.bounds));
			}
		}

		void CheckCollision()
		{
			Bounds _a, _b;
			bool _bFirst;
			Color _red = Color.red;
			for (int i = 0, j, imax = list.Count; i < imax; i++)
			{
				_a = list[i].bounds;
				_bFirst = false;
				for (j = i+1; j < imax; j++)
				{
					_b = list[j].bounds;
					if (Intersects(ref _a, ref _b))
					{
						if (_bFirst == false)
						{
							list[i].material.color = _red;
						}
						list[j].material.color = _red;
						_bFirst = true;
					}
				}
			}
		}

		bool Intersects(ref Bounds _a,ref Bounds _b)
		{
			return (_a.min.x > _b.max.x || _a.max.x < _b.min.x 
				||	_a.min.y > _b.max.y || _a.max.y < _b.min.y 
				||	_a.min.z > _b.max.z 
				? false 
				: _a.max.z >= _b.min.z);
		}
	}
}

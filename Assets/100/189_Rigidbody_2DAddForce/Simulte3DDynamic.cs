using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simulte3DDynamic
{
	public enum eSimulateDir { Left, Right, Up, Down};

	[System.Serializable]
	public class KeyAndSpawn
	{
		public KeyCode key;
		public eSimulateDir simDir;
		public Transform trans;
	}
	
	public class Simulte3DDynamic : MonoBehaviour
	{
		public static Simulte3DDynamic ins { get; private set; }
		//public int COUNT = 3;
		public Rigidbody prefab;
		public Transform center;
		[Range(0.01f, 1.0f)]public float spawnXZ = 0.2f;
		public float power = 10f;
		public List<KeyAndSpawn> list = new List<KeyAndSpawn>();

		private void Awake()
		{
			ins = this;
		}


		//private void Update()
		//{
		//	for(int i = 0; i < list.Count; i++)
		//	{
		//		if (Input.GetKeyDown(list[i].key))
		//		{
		//			SpawnAndForce(list[i].trans, 5);
		//		}
		//	}
		//}

		public List<TransformInfo> StartSimulate(eSimulateDir _simDir, int _count)
		{
			//Debug.Log(1);
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].simDir == _simDir)
				{
					//Debug.Log(i);
					return SpawnAndForce(list[i].trans, _count);
				}
			}
			return null;
		}

		List<TransformInfo> SpawnAndForce(Transform _spawn, int _count)
		{
			Vector3 _pos, _dir;
			Rigidbody _r;
			List<TransformInfo> _list = new List<TransformInfo>();
			for (int i = 0; i < _count; i++)
			{
				_pos = _spawn.position;
				_pos.x		+= Random.Range(-spawnXZ, +spawnXZ);
				_pos.z		+= Random.Range(-spawnXZ, +spawnXZ);
				_r = Instantiate(prefab, _pos, Quaternion.identity) as Rigidbody;
				_r.gameObject.SetActive(true);
				_r.isKinematic = false;
				_r.transform.SetParent(transform);

				_dir = (_r.position - center.position).normalized;
				_r.AddForce(_dir * power);

				//작성해서 넣어둠....
				_list.Add(new TransformInfo( _r.transform));
			}

			return _list;
		}
	}
}
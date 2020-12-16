using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Simulte3DDynamic
{
	[System.Serializable]
	public class TransformInfo
	{
		public Transform t3;
		public Vector3 startPos;
		public Quaternion startRot;
		int axis;

		public TransformInfo(Transform _t)
		{
			t3 = _t;
			startPos = _t.position;
			startRot = _t.rotation;
			axis = Random.Range(0, 3);
		}

		public Vector3 GetPosition2DFrom3D()
		{
			Vector3 _pos = t3.position - startPos;
			_pos.y = _pos.z;
			_pos.z = 0;
			return _pos;
		}

		public void SetMove(Vector3 _delta) {
			t3.position = startPos + _delta;
		}

		public Quaternion GetRotation2DFrom3D()
		{
			if(axis == 0)
				return Quaternion.Euler(0, 0, t3.eulerAngles.x);
			else if (axis == 0)
				return Quaternion.Euler(0, 0, t3.eulerAngles.y);
			else 
				return Quaternion.Euler(0, 0, t3.eulerAngles.z);
		}

		public void SetRotate(Quaternion _delta)
		{
			t3.rotation = _delta;
		}
	}
	public class Player : MonoBehaviour
	{
		Animator animator;
		public Transform prefab;
		public Transform spawnPoint;
		//Coroutine coPair;


		void Start()
		{
			animator = GetComponent<Animator>();
		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				animator.SetTrigger("shoot");

				int _partCount = 5;
				List<TransformInfo> _list3D	= Simulte3DDynamic.ins.StartSimulate(eSimulateDir.Right, _partCount);
				List<TransformInfo> _list2D	= SpawnPart(_partCount);


				//if (coPair != null) {
				//	StopCoroutine(coPair);
				//}
				//3D 물리 -> 2D 위치에 적용...
				StartCoroutine(Co_PairMove(_list3D, _list2D));
			}
		}

		List<TransformInfo> SpawnPart(int _count)
		{
			List<TransformInfo> _list = new List<TransformInfo>();

			for(int i = 0; i < _count; i++)
			{
				Transform _t = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
				_list.Add(new TransformInfo(_t));
			}	

			return _list;
		}

		IEnumerator Co_PairMove(List<TransformInfo> _list3D, List<TransformInfo> _list2D)
		{
			float _endTime = Time.time + 2f;
			Vector3 _pos;
			//지정된 시간동안 이동...
			while (Time.time < _endTime)
			{
				for (int i = 0; i < _list3D.Count; i++)
				{
					_list2D[i].SetMove(_list3D[i].GetPosition2DFrom3D());
					_list2D[i].SetRotate(_list3D[i].GetRotation2DFrom3D());
				}
				yield return null;
			}

			//소멸하기...
			for (int i = 0; i < _list3D.Count; i++)
			{
				Destroy(_list3D[i].t3.gameObject);
			}
			for (int i = 0; i < _list2D.Count; i++)
			{
				Destroy(_list2D[i].t3.gameObject);
			}
		}
	}
}
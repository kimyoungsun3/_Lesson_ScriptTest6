using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExplosionTestNameSpace
{
	public class CreateObject : MonoBehaviour
	{
		public Transform prefab;
		public int prefabCount = 100;
		public Transform t1, t2;
		Vector3 p1, p2;

		void Start()
		{
			//Co_XXX();
			Coroutine _c = StartCoroutine(Co_XXX());
			//StopCoroutine(_c);


			//StartCoroutine("Co_XXX");
			Debug.Log("End");
		}

		IEnumerator Co_XXX()
		{
			p1 = t1.position;
			p2 = t2.position;
			float _x, _y, _z;
			Vector3 _pos = Vector3.zero;
			Quaternion _qua = Quaternion.identity;
			Transform _trans;
			for (int i = 0; i < prefabCount; i++)
			{
				_x = Random.Range(p1.x, p2.x);
				_y = Random.Range(p1.y, p2.y);
				_z = Random.Range(p1.z, p2.z);
				_pos.Set(_x, _y, _z);
				_trans = Instantiate(prefab, _pos, _qua);
				_trans.SetParent(transform);
				yield return null;
			}
		}

		//private void Update()
		//{
		//	Debug.Log("Update");
		//}
	}
}
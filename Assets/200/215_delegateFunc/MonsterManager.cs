using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Step215
{
	public class MonsterManager : MonoBehaviour
	{
		public Monster prefab;
		public List<Monster> list = new List<Monster>();
		float nextTime;
		public float NEXT_TIME = 2f;
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			if(Time.time > nextTime)
			{
				Monster _m = Instantiate(prefab, Random.onUnitSphere * 5, Quaternion.identity) as Monster;
				list.Add(_m);
				_m.InitData(100f, OnRemoveMonster);

				nextTime = Time.time + NEXT_TIME;
			}

		}

		void OnRemoveMonster(Monster _m)
		{
			list.Remove(_m);
			Destroy(_m.gameObject);
		}
	}
}
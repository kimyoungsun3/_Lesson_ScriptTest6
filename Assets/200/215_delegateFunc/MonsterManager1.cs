using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager1 : MonoBehaviour {
	public Monster1 prefab;
	public List<Monster1> list = new List<Monster1>();
	float nextTime;
	public float NEXT_TIME = 2f;
	
	void Update () {
		if(Time.time > nextTime)
		{
			Monster1 _m = Instantiate(prefab, Random.onUnitSphere * 5, Quaternion.identity) as Monster1;
			list.Add(_m);
			_m.InitData(100f, OnRemoveMonster);

			nextTime = Time.time + NEXT_TIME;
		}
	}

	void OnRemoveMonster(Monster1 _m)
	{
		list.Remove(_m);
		Destroy(_m.gameObject);
	}
}

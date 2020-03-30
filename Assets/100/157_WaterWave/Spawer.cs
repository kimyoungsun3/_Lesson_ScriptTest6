using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WaterWave
{
	public class Spawer : MonoBehaviour
	{
		[SerializeField] GameObject target;
		[SerializeField] float distance = 0.2f;
		// Use this for initialization
		void Start()
		{
			Vector3 _pos = target.transform.position;
			for (int i = 0; i < 100; i++)
			{
				_pos.x += distance;
				Instantiate(target, _pos, Quaternion.identity);
			}
		}


	}
}
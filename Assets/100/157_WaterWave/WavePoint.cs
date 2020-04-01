using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WaterWave
{
	public class WavePoint : MonoBehaviour
	{
		Transform trans;
		Vector3 startPos, pos;
		[SerializeField] float height, interval;

		private void Start()
		{
			trans		= transform;
			startPos	= trans.position;
		}

		private void Update()
		{
			float _theta = startPos.x + Time.time * interval;
			float _dx = Mathf.Cos(_theta);
			float _dy = Mathf.Sin(_theta) * height;
			pos.Set(startPos.x + _dx, startPos.y + _dy, startPos.z);
			trans.position = pos;
		}


	}
}
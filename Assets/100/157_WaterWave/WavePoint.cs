using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WaterWave
{
	public class WavePoint : MonoBehaviour
	{
		Vector3 startPos, pos;
		Transform trans;
		// Use this for initialization
		void Start()
		{
			trans		= transform;
			startPos	= trans.position;
		}

		// Update is called once per frame
		void Update()
		{
			float _theta	= startPos.x + Time.time;
			float _dx = Mathf.Cos(_theta);
			float _dy = Mathf.Sin(_theta);
			pos.Set(startPos.x + _dx, startPos.y + _dy, startPos.z);
			trans.position = pos;
		}
	}
}
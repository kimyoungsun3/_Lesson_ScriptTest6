using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WaterWave
{
	public class WavePoint : MonoBehaviour
	{
		Vector3 startPos;
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
			Vector3 _pos	= trans.position;
			float _theta	= startPos.x + Time.time;

			float _dx = Mathf.Cos(_theta);
			float _dy = Mathf.Sin(_theta);
			_pos.x = startPos.x + _dx;
			_pos.y = startPos.y + _dy;
			trans.position = _pos;
		}
	}
}
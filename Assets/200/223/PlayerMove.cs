using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Step223
{
	public class PlayerMove : MonoBehaviour
	{
		public float speed = 2f;
		Transform trans;
		void Start()
		{
			trans = transform;
		}

		void Update()
		{
			float _v = Input.GetAxisRaw("Vertical");
			float _h = Input.GetAxisRaw("Horizontal");
			Vector3 _move = new Vector3(_h, 0, _v);

			trans.Translate(_move.normalized * speed * Time.deltaTime);

		}
	}
}
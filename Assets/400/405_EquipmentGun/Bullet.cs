using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EquipmentTestNameSpace
{
	public class Bullet : MonoBehaviour
	{
		float speed = 20f;
		private void Start()
		{
			Destroy(gameObject, 3f);
		}

		public void SetParameter(float _speed)
		{
			speed = _speed;
		}

		// Update is called once per frame
		void Update()
		{
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
	}
}

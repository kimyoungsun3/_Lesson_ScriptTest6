using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _113_TransformSpace
{
	public class ForwardMove : MonoBehaviour
	{
		[SerializeField] float speed = 2f;
		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			float _v = Input.GetAxisRaw("Vertical");
			if (_v != 0)
				transform.Translate(_v * Vector3.forward * speed * Time.deltaTime);
		}
	}
}

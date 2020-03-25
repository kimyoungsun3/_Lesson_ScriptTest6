using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _409_FlyMode
{
	public class ThirdPersonMove : MonoBehaviour {
		[SerializeField] float moveSpeed = 3f;
		[SerializeField] float sideSpeed = 2f;
		ThirdPersonCameraNonTargetPC2 scpRotate;

		// Use this for initialization
		void Start() {
			scpRotate = GetComponent<ThirdPersonCameraNonTargetPC2>();
		}

		// Update is called once per frame
		void Update() {
			//if (Input.GetKey(KeyCode.W))
			float _v = Input.GetAxisRaw("Vertical");
			float _h = Input.GetAxisRaw("Horizontal");

			if (_v != 0)
			{
				transform.Translate(Vector3.forward * _v * moveSpeed * Time.deltaTime);
			}

			if (_h != 0)
			{
				transform.Translate(Vector3.right * _h * sideSpeed * Time.deltaTime);
			}

			if (Input.GetMouseButton(1))
			{
				scpRotate.Rotate();
			}
		}
	}
}

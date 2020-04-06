using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TranslateAndRotate
{
	public class SheepMove : MonoBehaviour
	{

		Transform trans;
		SpriteRenderer spriteRenderer;
		[SerializeField] float speed = 3f;

		void Start()
		{
			trans = transform;
			spriteRenderer = GetComponent<SpriteRenderer>();
		}

		void Update()
		{
			float _h = Input.GetAxisRaw("Horizontal");
			float _angleY = trans.rotation.eulerAngles.y;
			if (_h > 0 && _angleY == 180f)
				trans.rotation = Quaternion.Euler(0, 0, 0);
			else if (_h < 0 && _angleY == 0)
				trans.rotation = Quaternion.Euler(0, 180f, 0);

			if (_h != 0f)
				trans.Translate(Vector3.right * speed * Time.deltaTime);
		}
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TranslateAndRotate
{
	public class SheepMove2 : MonoBehaviour
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
			float _scaleX = trans.localScale.x;
			if (_h > 0 && _scaleX == -1f)
				trans.localScale = new Vector3(1f, 1f, 1f);
			else if (_h < 0 && _scaleX == 1f)
				trans.localScale = new Vector3(-1f, 1f, 1f);

			if (_h != 0f)
				trans.Translate(_h*Vector3.right * speed * Time.deltaTime);
		}
	}
}
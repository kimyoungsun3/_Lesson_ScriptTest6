using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _410_AnimationTest
{
	public class PlayerController : MonoBehaviour
	{
		Animator animator;
		Transform trans;
		[SerializeField] float speedMove = 3f;
		[SerializeField] float speedTurn = 90f;
		int hasMove = Animator.StringToHash("move");
		int hasBomb = Animator.StringToHash("bomb");
		void Start()
		{
			animator = GetComponent<Animator>();
			trans = transform;
		}

		// Update is called once per frame
		void Update()
		{
			float _v = Input.GetAxisRaw("Vertical");
			float _h = Input.GetAxisRaw("Horizontal");
			float _move = 0;
			if(_v != 0)
			{
				Debug.Log(_v + ":" + Vector3.forward +":"+ speedMove +":"+ Time.deltaTime);
				trans.Translate(_v * Vector3.forward * speedMove * Time.deltaTime);
				_move = 1;
			}
			if(_h != 0)
			{
				trans.Rotate(_h * Vector3.up * speedTurn * Time.deltaTime);
				_move = 1;
			}

			animator.SetFloat(hasMove, _move);

			if (Input.GetKeyDown(KeyCode.Space))
			{
				animator.SetTrigger(hasBomb);
			}

		}
	}

}
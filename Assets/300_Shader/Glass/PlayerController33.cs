using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController33 : MonoBehaviour
{
	public float speed = 3f;
	public float speedTurn = 90f;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		float _h = Input.GetAxisRaw("Horizontal");
		float _v = Input.GetAxisRaw("Vertical");


		//키입력을 받으면.....
		if (_v != 0)
		{
			transform.Translate(_v * Vector3.forward * speed * Time.deltaTime);
		}
	}
}

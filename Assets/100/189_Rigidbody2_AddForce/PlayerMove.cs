using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace _189_Rigidbody2_AddForce
{
	public class PlayerMove : MonoBehaviour
	{
		public float speed = 2f;
		public float speedTurn = 90f;
		float h, v;
		// Update is called once per frame
		public float UPDATE_MAX = 100000;
		public float FIXEDUPDATE_MAX = 100000;

		// Start is called before the first frame update
		void Start()
		{

		}

		//private void FixedUpdate()
		//{
		//	//Debug.Log("FixedUpdate " + Time.deltaTime);	
		//}

		void Update()
		{
			//Debug.Log("Update " + Time.deltaTime);
			h = Input.GetAxisRaw("Horizontal");
			v = Input.GetAxisRaw("Vertical");
			if (v != 0)
			{
				transform.Translate(v * Vector3.forward * speed * Time.deltaTime);
			}

			if (h != 0)
			{
				transform.Rotate(h * Vector3.up * speedTurn * Time.deltaTime);
			}
		}
	}
}

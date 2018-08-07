using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InstantiateTest{
	public class UserClasses : MonoBehaviour {
		public Transform bullet;
		public Transform spawn;
		public float moveSpeed = 2;
		public float turnSpeed = 90;
		Vector3 move, turn;
		bool bMove, bTurn;

		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			bMove = false;
			bTurn = false;

			if (Input.GetKey (KeyCode.W)) {
				move = Vector3.forward * moveSpeed * Time.deltaTime;
				bMove = true;
			}else if (Input.GetKey (KeyCode.S)) {
				move = -Vector3.forward * moveSpeed * Time.deltaTime;
				bMove = true;
			}
			if (Input.GetKey (KeyCode.D)) {
				turn = Vector3.up * turnSpeed * Time.deltaTime;
				bTurn = true;
			}else if (Input.GetKey (KeyCode.A)) {
				turn = -Vector3.up * turnSpeed * Time.deltaTime;
				bTurn = true;
			}

			if (bMove) {
				transform.Translate (move);
			}
			if (bTurn) {
				transform.Rotate (turn);
			}

			if (Input.GetMouseButtonDown (0)) {
				Transform _tran = Instantiate (bullet, spawn.position, spawn.rotation) as Transform;
				Rigidbody _rb = _tran.GetComponent<Rigidbody> (); 
				_rb.AddForce (_tran.forward * 500);
			}
		}
	}
}

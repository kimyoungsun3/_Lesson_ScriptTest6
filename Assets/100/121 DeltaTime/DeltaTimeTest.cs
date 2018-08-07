using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeltaTimeTest{
	public class DeltaTimeTest : MonoBehaviour {
		public float moveSpeed = 2f;
		Vector3 move;
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			move.x = Input.GetAxisRaw ("Horizontal");
			move.y = Input.GetAxisRaw ("Vertical");
			move = move.normalized;
			transform.Translate (move * moveSpeed);
		}
	}
}
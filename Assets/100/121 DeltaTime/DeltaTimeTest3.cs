using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeltaTimeTest{
	public class DeltaTimeTest3 : MonoBehaviour {
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
			transform.Translate (move * moveSpeed * Time.deltaTime);
		
			Vector3[] ll = {
				new Vector3 (0.1f, 0.1f, 0.1f),
				new Vector3 (1, 1, 1), 
				new Vector3 (2, 2, 2)
			};

			//for(int i = 0, iMax = ll.Length; i < iMax; i++)
			//	//.....
			//for (int i = 0, iMax = ll.Length; i < iMax; i++)
			//	Debug.Log (ll [i] + " > " + ll [i].normalized);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lerp{
	public class LerpTest6 : MonoBehaviour {
		
		public float knockBackMeter = 5f;
		public float knockTime = .2f;
		float speedKnock;
		Vector3 nextPos;


		void Update () {

			if (Input.GetMouseButtonDown (0)) {
				nextPos 		= transform.position - transform.forward * knockBackMeter;
				speedKnock 	= 1f / knockTime;
			}

			transform.position = Vector3.Lerp(
				transform.position, 
				nextPos, 
				speedKnock * Time.deltaTime
			);
		}
	}
}

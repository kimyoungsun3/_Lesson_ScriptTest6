using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lerp{
	public class LerpTest7 : MonoBehaviour {		
		public float knockBackUnit = 5f;
		public float knockTime = .2f;
		float speedKnock;
		Vector3 nextPos;
		float powerTime = 0f;

		void Update () {
			if (Input.GetMouseButtonDown (0)) {
				powerTime = 0f;
			} else if (Input.GetMouseButton (0)) {
				powerTime += Time.deltaTime;
			} else if (Input.GetMouseButtonUp (0)) {
				nextPos 		= transform.position - transform.forward * powerTime* knockBackUnit;
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

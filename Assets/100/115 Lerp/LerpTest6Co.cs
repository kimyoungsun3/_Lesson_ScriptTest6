using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lerp{
	public class LerpTest6Co : MonoBehaviour {
		
		public float knockBackMeter = 5f;
		public float knockTime = .2f;
		float speedKnock;
		Vector3 nextPos;


		void Update () {

			if (Input.GetMouseButtonDown (0)) {
				nextPos 		= transform.position - transform.forward * knockBackMeter;
				speedKnock 	= 1f / knockTime;

				StopAllCoroutines ();
				StartCoroutine (Co_KnockBack ());
			}

		}

		IEnumerator Co_KnockBack(){
			while (Vector3.Distance (transform.position, nextPos) >= 0.001f) {
				transform.position = Vector3.Lerp (
					transform.position, 
					nextPos, 
					speedKnock * Time.deltaTime
				);
				yield return null;
			}
		}
	}
}

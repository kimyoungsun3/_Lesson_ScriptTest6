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
		public Vector2 knockMinMax = new Vector2(1f, 10f);
		public int mode = 0;

		void Update () {
			if (Input.GetMouseButtonDown (0)) {
				powerTime = 0f;
			} else if (Input.GetMouseButton (0)) {
				powerTime += Time.deltaTime;
			} else if (Input.GetMouseButtonUp (0)) {
				//Debug.Log (powerTime);
				powerTime 	= Mathf.Clamp (powerTime, knockMinMax.x, knockMinMax.y);
				//Debug.Log ("> " + powerTime);
				nextPos 	= transform.position - transform.forward * powerTime* knockBackUnit;
				speedKnock 	= 1f / knockTime;
			}

			if(mode == 0)
				transform.position = Vector3.Lerp(
					transform.position, 
					nextPos, 
					speedKnock * Time.deltaTime
				);
			else
				transform.position = Vector3.Slerp(
					transform.position, 
					nextPos, 
					speedKnock * Time.deltaTime
				);
		}
	}
}

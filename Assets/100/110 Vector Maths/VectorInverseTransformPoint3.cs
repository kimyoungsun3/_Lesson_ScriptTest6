﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VectorTest{
	

	public class VectorInverseTransformPoint3 : MonoBehaviour {
		[Header("Global로 이동")]
		public Transform target;
		public Vector3 offset;

		[Header("----보기만하세요---")]
		public Vector3 dir;


		void OnDrawGizmos(){
			//Debug.Log (" > P1를 회전, 사이즈 변경 해보삼");
			if (target != null) {
				Gizmos.color = Color.blue;
				target.position	= transform.position + offset;
				dir = target.position - transform.position;
			}
		}
	}
}

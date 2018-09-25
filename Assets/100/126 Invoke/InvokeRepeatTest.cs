using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InvokeTest{
	public class InvokeRepeatTest : MonoBehaviour {
		public Transform prefab;

		// Use this for initialization
		void Start () {
			Debug.Log ("0. 시작, Invoke가동(2초뒤에 반복)." + Time.time);
			InvokeRepeating ("SpawnObject", 2f, 2f);	

		}

		void SpawnObject(){
			Debug.Log ("0. 등록된 InvokeRepeating실행:" + Time.time);
			Instantiate (prefab, transform.position + Random.onUnitSphere, Quaternion.identity);
		}

		public float time;
		void Update(){
			time = Time.time;
		}
	}
}
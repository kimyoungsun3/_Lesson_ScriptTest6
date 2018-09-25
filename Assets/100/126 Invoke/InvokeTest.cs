using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InvokeTest{
	public class InvokeTest : MonoBehaviour {
		public Transform prefab;

		// Use this for initialization
		void Start () {
			Debug.Log ("0. 시작, Invoke가동(11초뒤에)." + Time.time);
			Invoke ("SpawnObject", 11f);
		}

		void SpawnObject(){
			Debug.Log ("0. 등록된 Invoke실행:" + Time.time);
			Instantiate (prefab, transform.position + Random.onUnitSphere, Quaternion.identity);

			gameObject.SetActive (false);
		}

		public float time;
		void Update(){
			time = Time.time;
		}
	}
}
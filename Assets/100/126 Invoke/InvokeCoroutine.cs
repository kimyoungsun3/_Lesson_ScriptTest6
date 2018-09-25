using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InvokeTest{
	public class InvokeCoroutine : MonoBehaviour {
		public Transform prefab;

		// Use this for initialization
		IEnumerator Start () {
			Debug.Log ("0. 시작, Invoke가동." + Time.time);
			Invoke ("SpawnObject", 11f);

			yield return new WaitForSeconds (5f);
			Debug.Log ("1. Scripts 비활성화." + Time.time);
			enabled = false;

			yield return new WaitForSeconds (5f);
			Debug.Log ("2. GameObject 비활성화." + Time.time);
			gameObject.SetActive (false);	//-> Coroutine kill

			yield return new WaitForSeconds (5f);
			Debug.Log ("3. GameObject Destroy" + Time.time);
			Destroy (gameObject);
		}

		void SpawnObject(){
			Debug.Log ("0. 등록된 Invoke실행" + Time.time);
			Instantiate (prefab, transform.position + Random.onUnitSphere, Quaternion.identity);
		}

		public float time;
		void Update(){
			time = Time.time;
		}
	}
}
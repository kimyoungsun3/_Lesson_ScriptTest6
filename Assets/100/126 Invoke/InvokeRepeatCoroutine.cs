using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InvokeTest{
	public class InvokeRepeatCoroutine : MonoBehaviour {
		public Transform prefab;

		// Use this for initialization
		IEnumerator Start () {
			InvokeRepeating ("SpawnObject", 2f, 2f);	

			yield return new WaitForSeconds (5f);
			Debug.Log ("Script disable");
			enabled = false;

			yield return new WaitForSeconds (5f);
			Debug.Log ("GameObject not active");
			gameObject.SetActive (false);	//-> Coroutine kill

			yield return new WaitForSeconds (5f);
			Debug.Log ("GameObject Destroy");
			Destroy (gameObject);
		}

		void SpawnObject(){
			Debug.Log ("InvokeRepeat Alive");
			Instantiate (prefab, transform.position + Random.onUnitSphere, Quaternion.identity);
		}

		public float time;
		void Update(){
			time = Time.time;
		}
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
		//Coroutine _co = StartCoroutine( Co_Move (10));
		//Coroutine _co2 = StartCoroutine( Co_Move (10));
		//StopCoroutine (_co);


		StartCoroutine( "Co_Move", 10);
		//StartCoroutine( "Co_Move", 10);
		//StartCoroutine( "Co_Move", 10);
		//StopCoroutine ("Co_Move");
	}

	void Update () {
		Debug.Log ("Update");
		//transform.Translate (Vector3.forward * 3f * Time.deltaTime);
	}

	IEnumerator Co_Move(int _x){
		while (true) {
			Debug.Log ("Co_Move");
			transform.Translate (Vector3.forward * 3f * Time.deltaTime);
			//yield return null;
			//yield return new WaitForSeconds(.2f);
			//JS

		}
	}
}

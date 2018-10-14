using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour {
	//-----------------------
	void Awake(){
		Debug.Log (this + " Awake");
	}
	void OnEnable () {
		Debug.Log (this + " OnEnable");		
	}

	// Use this for initialization
	void Start () {
		Debug.Log (this + " Start");
		//Coroutine _co = StartCoroutine( Co_Move (10));
		//Coroutine _co2 = StartCoroutine( Co_Move (10));
		//StopCoroutine (_co);

		StartCoroutine (Co_Move (10));
		//StartCoroutine( "Co_Move", 10);
		//StartCoroutine( "Co_Move", 10);
		//StartCoroutine( "Co_Move", 10);
		//StopCoroutine ("Co_Move");
	}

	//------------------------
	void FixedUpdate () {
		Debug.Log (this + " FixedUpdate");		
	}
	void Update () {
		Debug.Log (this + " Update");		
	}

	IEnumerator Co_Move(int _x){
		while (true) {
			Debug.Log ("Co_Move");
			transform.Translate (Vector3.forward * 3f * Time.deltaTime);
			yield return null;
			//yield return new WaitForSeconds(.2f);
			//JS

		}
	}

	void LateUpdate () {
		Debug.Log (this + " LateUpdate");		
	}

	//------------------------
	void OnDisable () {
		Debug.Log (this + " OnDisable");		
	}
}

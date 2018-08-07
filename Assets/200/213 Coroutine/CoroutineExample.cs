using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour {
	public Transform target;
	public float speed = 1f;

	void Start () {
		Debug.Log ("StartCoroutine");
		StartCoroutine (CoReach (target));
	}

	IEnumerator CoReach(Transform _target){
		while(Vector3.Distance(transform.position, _target.position) > 0.05f){
			
			transform.position = Vector3.Lerp(transform.position, _target.position, speed * Time.deltaTime);
			yield return null;
		}

		Debug.Log("Reached the target");
		yield return new WaitForSeconds(3f);
		Debug.Log("Coroutine is finished.");
	}
}

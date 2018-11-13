using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClickObject2 : MonoBehaviour {
	public float speed = 4f;
	Vector3 move;
	public float radius = 3f;
	public LayerMask mask;
	public Transform pickPoint;
	public Transform target;

	// Update is called once per frame
	void Update () {
		float _h = Input.GetAxisRaw ("Horizontal");
		float _v = Input.GetAxisRaw ("Vertical");
		move = new Vector3(_h, 0, _v);
		transform.Translate (move.normalized * speed * Time.deltaTime);

		if (Input.GetMouseButtonDown (0)) {
			CheckAndList ();
		} else if (Input.GetMouseButtonDown (1)) {
			CheckAndRemove ();
		}
	}

	void CheckAndList(){
		Collider[] _cols = Physics.OverlapSphere (transform.position, radius, mask);
		if(target == null && _cols.Length > 0){
			target = _cols [0].transform;
			target.position = pickPoint.position;
			target.rotation = pickPoint.rotation;
			target.SetParent (pickPoint);
			target.GetComponent<Rigidbody> ().isKinematic = true;

		}
	}

	void CheckAndRemove(){
		if (target != null ) {
			target.GetComponent<Rigidbody> ().isKinematic = false;
			target.SetParent (null);
			target = null;
		}
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere (transform.position, radius);
	}
}

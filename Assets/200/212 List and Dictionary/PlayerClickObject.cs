using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClickObject : MonoBehaviour {
	public float speed = 4f;
	Vector3 move;
	public float radius = 3f;
	public LayerMask mask;
	public Dictionary<Collider, Transform> dicList = new Dictionary<Collider, Transform>();


	// Use this for initialization
	void Start () {
		
	}
	
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
		Debug.Log (_cols.Length);
		for (int i = 0; i < _cols.Length; i++) {
			if (!dicList.ContainsKey (_cols [i])) {
				dicList.Add (_cols [i], _cols [i].transform);
				_cols [i].transform.SetParent (transform);
			}
		}
	}

	void CheckAndRemove(){
		if (dicList.Count > 0) {
			//foreach (KeyValuePair<Collider, Transform> kv in dicList) {}
			//foreach (Transform _col in dicList.Values) {}
			foreach (Collider _col in dicList.Keys) {
				dicList.Remove (_col);
				_col.transform.SetParent (null);
				break;
			}
		}
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere (transform.position, radius);
	}
}

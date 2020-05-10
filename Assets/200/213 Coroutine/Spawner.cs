using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public Transform player;
	public Transform prefabEnemy;
	public float spawneTime = 2f;
	public Transform[] points;

	// Use this for initialization
	void Start () {
		StartCoroutine (CoSpanwer (spawneTime));
	}

	IEnumerator CoSpanwer(float _t){
		WaitForSeconds _wait = new WaitForSeconds (_t);
		Transform _trans;
		CoroutineExample _scp;
		while (true) {	
			yield return _wait;		
			int _idx = Random.Range (0, points.Length);
			_trans	= Instantiate (prefabEnemy, points [_idx].position, points [_idx].rotation) as Transform;
			_scp	= _trans.GetComponent<CoroutineExample> ();
			if (_scp != null) {
				_scp.SetTarget (player);
			}

		}
	}

}

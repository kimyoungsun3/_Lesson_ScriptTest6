using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InstantiateTest{
	public class Bullet : MonoBehaviour {

		void OnTriggerEnter(Collider _col){
			Enemy _scp = _col.GetComponent<Enemy> ();
			if (_scp != null) {
				_scp.TakeDamage (10f);
			}
			//Destroy (gameObject);
		}
	}
}
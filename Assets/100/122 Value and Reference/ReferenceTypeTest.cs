using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ValueAndReference{
	public class ReferenceTypeTest : MonoBehaviour {

		void Start () {
			Debug.Log ("--- Reference Type Script(V3) ---");	
			OtherScripts _scp1 = GetComponent<OtherScripts> ();
			OtherScripts _scp2 = _scp1;
			_scp1.v = new Vector3 (1, 2, 3);
			_scp2.v *= 10;
			Debug.Log (_scp1.v + " , " + _scp2.v);

			Debug.Log ("--- Reference Type Script(Quaternion) ---");	
			_scp1.q = Quaternion.identity;
			_scp2.q = Quaternion.Euler(Vector3.up * 90);
			Debug.Log (_scp1.q + " , " + _scp2.q);

			//x = transform.position.x = 1.0f;
		}
	}
}
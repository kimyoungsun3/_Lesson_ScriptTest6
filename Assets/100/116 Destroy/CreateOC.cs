using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Destroy{
	public class CreateOC : MonoBehaviour {
		public GameObject goPrefab;
		public Transform transPrefab;
		public Collider colPrefab;
		public Rigidbody rbPrefab;
		public XXXX scpPrefab;
		//public DestroyOC scpPrefab2;

		GameObject goTarget;

		void Start () {
			Debug.Log (" 1,2,3,4,5 Instanciate GameObject");
			Debug.Log (" C AddComponent<T>");
			Debug.Log (" G GetComponet<T>");			
		}
		
		// Update is called once per frame
		void Update () {

			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				GameObject _go = Instantiate (goPrefab, transform.position, Quaternion.identity);
			}else if (Input.GetKeyDown (KeyCode.Alpha2)) {
				Transform _trans = Instantiate (transPrefab, transform.position, Quaternion.identity);
			}else if (Input.GetKeyDown (KeyCode.Alpha3)) {
				Collider _col = Instantiate (colPrefab, transform.position, Quaternion.identity);
			}else if (Input.GetKeyDown (KeyCode.Alpha4)) {
				Rigidbody _rb = Instantiate (rbPrefab, transform.position, Quaternion.identity);
				_rb.velocity = _rb.transform.forward * 3f;
			}else if (Input.GetKeyDown (KeyCode.Alpha5)) {
				XXXX _scp = Instantiate (scpPrefab, transform.position, Quaternion.identity);
				_scp.InvokeMove ();



			} else if (Input.GetKeyDown (KeyCode.C)) {
				goTarget.AddComponent<DDDDD> ();
				Debug.Log ("AddComponet > Add Scripts");
			} else if (Input.GetKeyDown (KeyCode.G)) {
				DDDDD _scp = goTarget.GetComponent<DDDDD> ();
				_scp.SetData (100f, 1f);
				Debug.Log ("Create Prefab is Script Data that is changed");
			}
		}
	}
}
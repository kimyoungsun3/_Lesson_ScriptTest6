using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComponentTest{
	public class ComponentTest : MonoBehaviour {
		public GameObject go;
		public Transform trans;
		public BoxCollider col;
		public MeshRenderer render;
		public Rigidbody rb;

		void Start () {
			//유니티 기본 변수...
			go 		= gameObject;
			trans 	= transform;
			Debug.Log ("go:" + go);
			Debug.Log ("trans:" + trans);

			//유니티 기본 변수에서 현재는 GetComponet로 받아야함...
			col = GetComponent<BoxCollider> ();		//col = collider;
			render = GetComponent<MeshRenderer>();
			Debug.Log ("col:" + col);
			Debug.Log ("render:" + render);

			//컴포너트가 없으면 null...
			rb = GetComponent<Rigidbody> ();
			Debug.Log ("rb:" + rb);

		}
	}
}

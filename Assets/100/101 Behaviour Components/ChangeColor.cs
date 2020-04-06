using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComponentTest{
	public class ChangeColor : MonoBehaviour {
		Renderer renderer;
		Vector3 border;
		void Start(){
			renderer = GetComponent<Renderer> ();
			Debug.Log ("push key R, G and B");

			Camera _c = Camera.main;
			Debug.Log(_c.orthographicSize);
			Debug.Log(_c.aspect * _c.orthographicSize);
			border.x = _c.aspect * _c.orthographicSize;
			Debug.Log(border.x);
		}

		public float speed = 2f;
		// Update is called once per frame
		void Update () {

			float _h = Input.GetAxisRaw("Horizontal");
			float _v = Input.GetAxisRaw("Vertical");
			Vector3 _pos = transform.position;
			transform.Translate(new Vector3(_h, _v, 0) * speed * Time.deltaTime);
			Debug.Log(transform.localPosition + ":" + border);
			if(Mathf.Abs(transform.localPosition.x) > Mathf.Abs(border.x))
			{
				transform.localPosition = _pos;
			}

			if (Input.GetKeyDown (KeyCode.R)) {
				renderer.material.color = Color.red;
			} else if (Input.GetKeyDown (KeyCode.G)) {
				renderer.material.color = Color.green;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				renderer.material.color = Color.blue;
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMove : MonoBehaviour {
	public float moveSpeed = 7f;
	Vector2 moveDelta = new Vector2(1, 0);
	Vector2 limitLeft, limitRight;
	Vector2 screenInfo;
	Transform trans;
	float h;


	// Use this for initialization
	void Start () {
		trans = transform;
		float _sizeX = GetComponent<Renderer> ().bounds.extents.x;
		//float _sizeY = GetComponent<Renderer> ().bounds.extents.y;
		screenInfo.Set (Camera.main.aspect * Camera.main.orthographicSize + _sizeX, Camera.main.orthographicSize);// + _sizeY);

		limitLeft.Set(-screenInfo.x, trans.position.y);
		limitRight.Set(screenInfo.x, trans.position.y);
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxisRaw ("Horizontal");
		if (h != 0) {
			moveDelta.Set (h * moveSpeed * Time.deltaTime, 0);
			trans.Translate (moveDelta);

			if (trans.position.x < -screenInfo.x) {
				trans.position = limitRight;
			}else if(trans.position.x > screenInfo.x){
				trans.position = limitLeft;
			}
		}
	}


	void OnTriggerEnter2D(Collider2D _col){
		if (_col.CompareTag ("Block")) {
			Destroy (gameObject);
		}
	}
}

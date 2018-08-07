using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour {
	public float moveSpeed = 7f;
	Vector2 moveDown;
	Vector2 screenInfo;
	Transform trans;
	float h;
	public event System.Action onDeath;


	// Use this for initialization
	void Start () {
		trans = transform;
		float _sizeY = GetComponent<Renderer> ().bounds.extents.y;
		screenInfo.Set (Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize + _sizeY);
		//Debug.Log (_sizeY + ":" + trans.localScale.x);
	}
	
	// Update is called once per frame
	void Update () {
		moveDown.Set (0, -moveSpeed * Time.deltaTime);
		trans.Translate (moveDown);

		//delete from under y
		if (trans.position.y < -screenInfo.y) {
			if (onDeath != null) {
				onDeath ();
			}
			Destroy (gameObject);
		}
	}
}

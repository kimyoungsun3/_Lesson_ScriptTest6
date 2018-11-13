using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveUpdate : MonoBehaviour {
	public float moveSpeed;
	Vector3 moveDir;
	//float height;
	public Slider hpSlider;
	public float hp = 100;
	public Transform hpTrans;

	void Start () {
		//height = transform.position.y;
		if (hpSlider != null) {
			hpSlider.value = hp;
			hpTrans.localScale = Vector3.one;
		}
	}

	void Update () {
		float _h = Input.GetAxisRaw ("Horizontal");
		float _v = Input.GetAxisRaw ("Vertical");

		//Debug.Log (_h +":"+ _v);
		Move (_h, _v);

		if (Input.GetMouseButtonDown (1)) {
			hp -= 10f;
			if (hpSlider != null) {
				hpSlider.value = hp;

				hpTrans.localScale = new Vector3(hp/100f, 1, 1);
			}
		}
		
	}

	void Move(float _h, float _v){
		if (_h != 0 || _v != 0) {
			//Debug.Log (" > ");
			moveDir.Set (_h, 0, _v);
			moveDir = moveDir.normalized;
			transform.Translate (moveDir * moveSpeed * Time.deltaTime);
		}
	}
}

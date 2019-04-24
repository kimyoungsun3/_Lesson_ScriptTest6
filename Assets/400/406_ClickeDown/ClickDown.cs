using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDown : MonoBehaviour {

	public float size;
	public float speedDownSize = .1f;
	public float speedClickSize = .6f;
	Transform trans;
	void Start () {
		trans = transform;
	}

	float clickTime;
	Vector3 dummyV3;

	private void FixedUpdate()
	{
		Debug.Log("FixedUpdate:" + Time.fixedDeltaTime);
	}
	void Update () {

		Debug.Log(Time.timeScale + " Update:" + Time.deltaTime);
		if (Input.GetKeyDown(KeyCode.Alpha1))
			Time.timeScale = 0.1f;
		else if (Input.GetKeyDown(KeyCode.Alpha2))
			Time.timeScale = 1f;
		else if (Input.GetKeyDown(KeyCode.Alpha3))
			Time.timeScale = 10f;

		clickTime -= Time.deltaTime;
		if(clickTime < 0)
			size -= speedDownSize * Time.deltaTime;
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
		{
			size += speedClickSize * Time.deltaTime;
			clickTime = 1f;
		}

		size = Mathf.Clamp(size, 1, 100);
		Vector3 _scale = Vector3.one * size;
		trans.localScale = Vector3.SmoothDamp(trans.localScale, _scale, ref dummyV3 , 0.1f);
	}
}

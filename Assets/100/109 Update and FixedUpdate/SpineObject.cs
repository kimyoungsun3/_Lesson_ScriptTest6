using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpineObject : MonoBehaviour {
	public enum eRotateAxis { X, Y, Z}
	[SerializeField] eRotateAxis rotateType = eRotateAxis.Y;
	[SerializeField] float turnSpeed = 90f;
	Transform trans;
	Vector3 rotateAxis;

	void Start () {
		trans = transform;
		switch (rotateType)
		{
			case eRotateAxis.X: rotateAxis = new Vector3(1f, 0, 0); break;
			case eRotateAxis.Y: rotateAxis = new Vector3(0, 1f, 0); break;
			case eRotateAxis.Z: rotateAxis = new Vector3(0, 0, 1f); break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		trans.Rotate(rotateAxis * turnSpeed * Time.deltaTime );		
	}

}

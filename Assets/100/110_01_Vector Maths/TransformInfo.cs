using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransformInfo : MonoBehaviour {

	public Transform p0, p1, p2;
	public Text t0, t1, t2;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		t0.text = "" + p0.localPosition;
		t1.text = "" + p1.localPosition;
		t2.text = "" + p2.localPosition;
	}
}

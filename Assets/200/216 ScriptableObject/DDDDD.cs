using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDDDD : MonoBehaviour {

	// Use this for initialization
	private static DDDDD ins;
	void Start() {
		if (ins != null)
		{
			DestroyImmediate(this.gameObject);
			return;
		}
		DontDestroyOnLoad(gameObject);
		ins = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour {
	public enum PLUS_MODE { 
		local, world
	};
	public Transform[] list;
	public Vector3 offset = new Vector3(0, 0, 0);
	public PLUS_MODE mode = PLUS_MODE.local;
	public bool bSetting;
	Vector3[] poses;

	void Start(){
		poses = new Vector3[list.Length];
		for (int i = 0; i < list.Length; i++) {
			poses [i] = list [i].position;
		}
	}


	// Update is called once per frame
	void Update () {
		if (bSetting) {
			int _len = list.Length;

			if (mode == PLUS_MODE.local) {
				for (int i = 0; i < _len; i++) {
					list [i].position = poses [i];
					list [i].localPosition += offset;
				}
			} else if (mode == PLUS_MODE.world) {
				for (int i = 0; i < _len; i++) {
					list [i].position = poses [i];
					list [i].position += offset;
				}
			}


			bSetting = false;
		}
	}
}

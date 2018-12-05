using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui_ToopTip : MonoBehaviour {
	public static Ui_ToopTip ins { get; private set; }
	public UILabel label;
	public Camera cam3D, cam2D;

	void Awake(){
		ins = this;
		gameObject.SetActive (false);
	}

	public void Show(string _str, bool _b, Vector3 _pos){
		if (_b) {
			label.text = _str;
		}
		gameObject.SetActive (_b);


		_pos = cam3D.WorldToViewportPoint (_pos);
		_pos = cam2D.ViewportToWorldPoint (_pos);
		_pos.z = transform.position.z;
		transform.position = _pos;
	}
}

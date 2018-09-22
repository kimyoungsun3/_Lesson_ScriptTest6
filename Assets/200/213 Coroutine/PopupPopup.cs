using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupPopup : MonoBehaviour {

	public List<Transform> list = new List<Transform> ();
	// Use this for initialization
	void Start () {
		StartCoroutine (Co_Init ());
	}

	IEnumerator Co_Init(){
		for (int i = 0, iMax = list.Count; i < iMax; i++) {
			list [i].gameObject.SetActive (false);
		}


		bool _bWait = true;
		//-------------------
		//111111111111
		//-----------------------
		Debug.Log ("1-1");
		list [0].gameObject.SetActive (true);
		Ui_Xxx _scp = list [0].GetComponent<Ui_Xxx> ();

		Debug.Log (_scp);
		_scp.InvokeEventRegister (delegate(string _str) {
			list [0].gameObject.SetActive (false);
			Debug.Log("Click 1" + _str);
			_bWait = false;
		});

		while (_bWait) {
			Debug.Log ("1-2");
			yield return null;
		}

		//-------------------
		// 2222222
		//-----------------------
		list [1].gameObject.SetActive (true);
		_bWait = true;
		_scp = list [1].GetComponent<Ui_Xxx> ();
		_scp.InvokeEventRegister (delegate(string _str) {
			list [1].gameObject.SetActive (false);
			Debug.Log("Click 2" + _str);
			_bWait = false;
		});

		while (_bWait) {
			yield return null;
		}

		//-------------------
		// 333333
		//-----------------------
		list [2].gameObject.SetActive (true);
		_bWait = true;
		_scp = list [2].GetComponent<Ui_Xxx> ();
		_scp.InvokeEventRegister ((_str) => {
			list [2].gameObject.SetActive (false);
			Debug.Log("Click 3" + _str);
			_bWait = false;
		});

		while (_bWait) {
			yield return null;
		}

		Debug.Log ("Start GOGO");
	}

	
}

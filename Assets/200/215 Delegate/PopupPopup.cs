using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DelegateTest{
	public class PopupPopup : MonoBehaviour {
		public PopouSub p1, p2, p3;

		// Use this for initialization
		IEnumerator Start () {
			//------------------------
			bool _bWait = true;

			p1.SetData (delegate() {
				Debug.Log("P1 Click");
				p1.gameObject.SetActive(false);
				_bWait = false;	
			});

			while (_bWait) {
				yield return null;
			}

			//------------------------
			_bWait = true;

			p2.SetData (() => {
				Debug.Log("P2 Click");
				p2.gameObject.SetActive(false);
				_bWait = false;	
			});

			while (_bWait) {
				yield return null;
			}

			//------------------------
			_bWait = true;

			p3.SetData (() => {
				Debug.Log("P3 Click");
				p3.gameObject.SetActive(false);
				_bWait = false;	
			});

			while (_bWait) {
				yield return null;
			}
		}	
	}
}

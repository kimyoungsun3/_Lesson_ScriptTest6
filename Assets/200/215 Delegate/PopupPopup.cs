using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DelegateTest{
	public class PopupPopup : MonoBehaviour {
		public PopouSub p1, p2, p3;

		// Use this for initialization
		IEnumerator Start () {
			yield return null;
			//------------------------
			bool _bWait = true;

			//p1.gameObject.SetActive(true);
			p1.SetCallback (delegate() {
				Debug.Log("P1 Click");
				p1.gameObject.SetActive(false);
				_bWait = false;	
			});

			while (_bWait) {
				yield return null;
			}

			//------------------------
			_bWait = true;
			//p2.gameObject.SetActive(true);
			p2.SetCallback (() => {
				Debug.Log("P2 Click");
				p2.gameObject.SetActive(false);
				_bWait = false;	
			});

			while (_bWait) {
				yield return null;
			}

			//------------------------
			_bWait = true;

			//p3.gameObject.SetActive(true);
			p3.SetCallback (() => {
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

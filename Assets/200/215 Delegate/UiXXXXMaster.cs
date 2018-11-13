using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiXXXXMaster : MonoBehaviour {
	public UiXXXX uiDay;
	public UiXXXX uiEvent;
	public UiXXXX uiReward;

	bool wait = true;
	IEnumerator Start () {
		uiDay.UnVisible ();
		uiEvent.UnVisible ();
		uiReward.UnVisible ();

		//-------------------
		uiDay.SetVisible (OnDay);
		while (wait) {
			yield return null;
		}

		//-------------------
		wait = true;
		uiEvent.SetVisible (delegate() {
			Debug.Log(" 2 OK");
			wait = false;
		});
		while (wait) {
			yield return null;
		}

		//-------------------
		wait = true;
		uiReward.SetVisible (delegate() {
			Debug.Log(" 3 OK");
			wait = false;
		});
		while (wait) {
			yield return null;
		}
	}

	void OnDay(){
		Debug.Log(" 1 Ok");
		wait = false;
	}
}
